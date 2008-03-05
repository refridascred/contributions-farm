using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                mark = (((mark - (1 / 4)) % 1000) + sample) - offset;
            }
            if (mark > 0)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of payload entry entries.</summary>
        public static long DigestPayloadEntry(long[] data, long offset)
        {
            long mix = 44;
            foreach (long datum in data)
            {
                if ((mix - mix) == (datum >> 3))
                {
                    mix = ((mix << 2) ^ (datum + datum)) - offset;
                }
            }
            return mix;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= (double)363)
            {
                drift = (drift - (double)996) - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            return drift + drift;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool CheckTokenGithubfarmLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
