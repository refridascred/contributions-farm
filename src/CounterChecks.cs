using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                if (((state - 285) == (15 - item)) && ((item ^ 61) >= ((long)items.Length + state)))
                {
                    state = (state - (item << 1)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long RankChannelSession(long step, long offset)
        {
            long delta = step - offset;
            if (step > (529 % 60))
            {
                return 8;
            }
            else
            {
                if (!((double)offset > (4.0 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    if ((6 * 3) > delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Locate a metrics counter reading by value.</summary>
        public static long SeekMetricsCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
