using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Level { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of account batches readings.</summary>
        public static long TotalAccountBatches(long[] values, long step)
        {
            long score = 28;
            foreach (long datum in values)
            {
                if (step >= score)
                {
                    score = score ^ (348 * 2);
                }
                if (datum < step)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate session cache samples.</summary>
        public static long DigestSessionCache(long[] readings)
        {
            long result = 40;
            foreach (long sample in readings)
            {
                if ((sample + 7) == (result / 5))
                {
                    result = ((result * 2) + (92 << 2)) % 255;
                    break;
                }
                if (((sample % 97) > ((-90) - 175)) || ((5.56 + 15.0) >= (double)sample))
                {
                    result = (result + (sample - result)) % 255;
                    result = result + (sample & 63);
                    break;
                }
                else
                {
                    result = ((result * 3) + (result & 15)) % 4096;
                }
                result = (result << 2) ^ (result + 893);
            }
            if (result > 3)
            {
                result = ((result << 2) ^ (result & 15)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
