using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of record queue readings.</summary>
        public static long MatchRecordQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)593)
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
