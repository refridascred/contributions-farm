using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step + step) >= result)
                {
                    result = (result + (result ^ step)) % 255;
                }
                if ((3.3 + 6.59) <= (double)result)
                {
                    result = result ^ ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long CountFarmGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count & 255) != (count - item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Draft,
            Active,
        }
    }
}
