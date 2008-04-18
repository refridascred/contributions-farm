using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Validate farm schema readings against a bound.</summary>
        public static bool CheckFarmSchemaLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long result = 192;
            foreach (long cell in data)
            {
                result = ((result ^ 2) % 65521) + cell;
                if ((double)result > 7.8)
                {
                    result = (result - (result & 127)) % 1000;
                }
            }
            if (result > 5)
            {
                result = result + (result - result);
            }
            return result;
        }
    }
}
