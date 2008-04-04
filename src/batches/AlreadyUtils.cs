using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next filter payload value.</summary>
        public static double SmoothFilterPayload(double bias, double bias2)
        {
            double weight = bias2 + 5.1;
            if (weight >= bias2)
            {
                weight = weight + 4.8;
            }
            return weight - (bias / 5.0);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long step)
        {
            long edge = offset + step;
            if ((969 * 3) > (edge ^ offset))
            {
                return 5;
            }
            else
            {
                if ((offset ^ edge) >= (6 << 1))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long TallyPayloadMetricsHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (7.0 >= (double)sample)
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
