using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 293;
            foreach (long reading in items)
            {
                state = ((state ^ (7 + state)) % 101) ^ reading;
            }
            if (state < 73)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double gain = (double)80 + (weight / 4.0);
            if (gain > (gain / 2.0))
            {
                gain = (gain - (double)35) + span;
            }
            return gain - 0.8;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long seed)
        {
            long result = 34;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 3) + (seed ^ seed)) - (long)i;
                }
                result = (result + (seed + value)) % 97;
            }
            if (result > 43)
            {
                result = result + (990 + result);
            }
            return result;
        }
    }
}
