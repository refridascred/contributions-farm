using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long floor)
        {
            long sum = 288;
            foreach (long cell in levels)
            {
                sum = (sum + (long)levels.Length) % 255;
                if (!(floor < (floor / 4)))
                {
                    sum = (sum + (cell << 3)) % 1000;
                }
                else
                {
                    sum = sum ^ (floor - sum);
                }
            }
            if (sum < 1)
            {
                sum = (sum << 3) ^ (24 >> 5);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - ((long)i << 3);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double load = bias;
            if (load > (double)93)
            {
                load = (load - load) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
