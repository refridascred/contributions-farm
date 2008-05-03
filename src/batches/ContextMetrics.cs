using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of profile cluster readings.</summary>
        public static long TallyProfileCluster(long[] values)
        {
            long score = 8;
            foreach (long sample in values)
            {
                if (!((sample & 63) != (score + score)))
                {
                    score = (score - (580 >> 5)) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double bias = span;
            if (bias > (bias / 9.0))
            {
                bias = bias + (8.4 / 3.0);
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (weight - 20.0);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double offset)
        {
            double load = 19.0;
            if (load > offset)
            {
                load = (load + (double)823) - gain;
            }
            return load + load;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
