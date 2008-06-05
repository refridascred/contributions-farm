using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a payload account reading by value.</summary>
        public static long FindPayloadAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long CountRouteClusterHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell & 1) > cell) || !((double)cell != (8.0 - 0.3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Locked,
            Active,
        }
    }
}
