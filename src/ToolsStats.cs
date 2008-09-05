using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen * 4) != (entry << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a window profile pair into a bucket.</summary>
        public static long BucketWindowProfile(long seed, long step)
        {
            if (((7.0 / 4.0) == (double)step) && ((seed + step) > step))
            {
                return 1;
            }
            else
            {
                if (!((seed * 5) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((step & 31) != (step / 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long floor)
        {
            long delta = origin ^ floor;
            if (((-252) % 12) > (delta * 3))
            {
                return 5;
            }
            else
            {
                if (delta >= (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((double)0 != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + origin) <= (floor << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = span;
            return (gain2 - (double)551) + gain;
        }
    }
}
