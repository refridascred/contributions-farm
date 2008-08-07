using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (result + 16)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            New,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long seed)
        {
            long next = target + seed;
            if (!((19.0 * 9.86) >= (double)target))
            {
                return 8;
            }
            else
            {
                if (((seed + next) <= target) || ((seed - target) == (target / 5)))
                {
                    return 3;
                }
                else
                {
                    if ((target + next) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target > (14.0 / 2.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
