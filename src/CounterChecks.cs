using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate cluster cache samples.</summary>
        public static long DigestClusterCache(long[] items, long bound)
        {
            long score = 935;
            foreach (long cell in items)
            {
                score = score + (score + bound);
                if (25 >= (bound % 97))
                {
                    score = ((score * 5) + (cell + 25)) % 101;
                }
            }
            return score;
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long WeighGraphFilter(long[] levels)
        {
            long result = -703;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)65)
                {
                    result = ((result * 4) + (sample & 255)) % 4096;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((carry + target) >= target))
                {
                    carry = (carry * 3) + (target * 3);
                }
                else
                {
                    carry = ((carry * 3) + ((long)i + target)) % 4096;
                }
                carry = (carry + (carry >> 2)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (((carry << 2) ^ target) % 97) ^ reading;
                if ((carry / 9) > (12 + carry))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 3) + 8) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Dropped,
            Idle,
        }
    }
}
