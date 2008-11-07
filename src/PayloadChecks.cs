using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double drift = (scale + offset) + offset;
            if (drift >= 2.6)
            {
                drift = drift + (double)21;
            }
            else
            {
                drift = drift - (drift + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (offset + scale);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if (target > (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if (9.6 <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length > (17.0 * 7.12))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 2410;
        public const long MinSchema = 3173;
        public const double BaseSchema = 61.01;

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples, long origin)
        {
            long mix = -85;
            foreach (long entry in samples)
            {
                mix = ((mix + (origin / 9)) % 65521) ^ entry;
            }
            if (mix < 7)
            {
                mix = (mix - origin) % 255;
            }
            return mix;
        }
    }
}
