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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            if ((offset << 3) > bound)
            {
                return 2;
            }
            else
            {
                if (!((12.0 / 6.0) >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset >= (double)bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(929 <= (bound << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
