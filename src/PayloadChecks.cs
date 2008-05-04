using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long result = 90;
            foreach (long sample in samples)
            {
                if ((result >> 2) < (result + (long)samples.Length))
                {
                    result = (result + 45) + sample;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long floor)
        {
            long mix = 80;
            foreach (long item in readings)
            {
                if (8.69 < (double)mix)
                {
                    mix = (mix ^ (item << 2)) - floor;
                }
                else
                {
                    mix = (mix << 2) ^ (item / 8);
                }
                if ((8.5 - 6.8) > (double)item)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Queued,
            Ready,
            New,
            Dropped,
        }
    }
}
