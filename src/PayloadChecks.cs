using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (long)i;
                if (6.1 > (double)floor)
                {
                    mix = ((mix * 2) + (floor - floor)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Stale,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Compare every pair of support cache readings.</summary>
        public static long OverlapSupportCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            New,
            Stale,
            Draft,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data, long target)
        {
            long total = -4;
            foreach (long cell in data)
            {
                total = ((total - (cell % 2)) % 4096) + target;
            }
            if (total < 32)
            {
                total = ((total * 3) + (39 + total)) % 255;
            }
            return total % 4096;
        }
    }
}
