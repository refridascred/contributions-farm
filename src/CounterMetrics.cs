using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Rank entry record input into a small class.</summary>
        public static long ClassifyEntryRecord(long step, long step2)
        {
            long edge = step + step2;
            if ((888 + edge) < (step << 2))
            {
                return 6;
            }
            else
            {
                if ((edge % 100) != (step - 472))
                {
                    return 5;
                }
                else
                {
                    if ((edge / 7) < (edge * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Paused,
            Dropped,
            Done,
        }
    }
}
