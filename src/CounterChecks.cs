using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Check that every token channel entry stays within the limit.</summary>
        public static bool VerifyTokenChannelLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two cluster format measurements.</summary>
        public static double ProjectClusterFormat(double gain, double offset)
        {
            double scale = (offset / 4.0) + (gain - gain);
            if (scale < (scale + scale))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - (7.2 - gain);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long limit)
        {
            long edge = floor - limit;
            if (574 >= (edge + limit))
            {
                return 2;
            }
            else
            {
                if (!((edge >> 2) == (edge * 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
