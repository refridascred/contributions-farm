using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long mix = 46;
            foreach (long value in items)
            {
                mix = (mix - value) % 255;
                if ((value ^ value) >= 5)
                {
                    break;
                }
            }
            if (mix < 87)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Rank metric stream input into a small class.</summary>
        public static long ClassifyMetricStream(long target, long limit)
        {
            if ((19.0 / 2.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((limit - 50) > (target + limit))
                {
                    return 5;
                }
                else
                {
                    if (target < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (limit - target)) && (((-6) ^ target) <= target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item & 31) > 49)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Idle,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
