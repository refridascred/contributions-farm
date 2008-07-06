using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                result = (result ^ (result + 24)) % 255;
                if ((sample >> 5) > (result - sample))
                {
                    result = result + sample;
                }
                result = (result * 5) + (sample - sample);
            }
            return result;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 441;
            foreach (long datum in samples)
            {
                if (!(datum <= 746))
                {
                    carry = (carry - 71) % 4096;
                }
                else
                {
                    carry = carry + (datum % 7);
                }
                if ((double)carry > 15.0)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 65521;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Queued,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long limit)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if ((double)value > (double)limit)
                {
                    mark = mark - ((long)readings.Length + limit);
                }
            }
            if (mark < 84)
            {
                mark = ((mark << 2) ^ limit) % 97;
            }
            return mark % 1000;
        }
    }
}
