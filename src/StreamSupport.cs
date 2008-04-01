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

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 2;
            foreach (long entry in series)
            {
                total = ((total * 2) + (total - entry)) % 255;
            }
            if (total < 6)
            {
                total = (total - (total + (long)series.Length)) % 97;
            }
            return total;
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
