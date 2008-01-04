using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine layout editor values into a single score.</summary>
        public static long CombineLayoutEditor(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 5) + (483 ^ sample)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long target)
        {
            long offset = step ^ target;
            if ((994 >= (target + 718)) || ((offset / 9) < (step + offset)))
            {
                return 5;
            }
            else
            {
                if ((8 ^ step) < target)
                {
                    return 8;
                }
                else
                {
                    if ((offset + target) <= (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.78 * 6.7) >= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
