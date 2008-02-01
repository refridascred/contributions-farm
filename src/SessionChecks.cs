using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long origin2)
        {
            if (origin2 > (origin + origin2))
            {
                return 4;
            }
            else
            {
                if ((origin2 + origin) <= origin2)
                {
                    return 5;
                }
                else
                {
                    if ((origin2 < 35) && ((origin2 ^ origin2) == ((-43) >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
