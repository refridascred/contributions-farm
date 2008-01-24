using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long anchor = 458;
            foreach (long datum in items)
            {
                if ((anchor >= (anchor >> 4)) || ((anchor * 3) == (12 ^ 79)))
                {
                    anchor = ((anchor << 2) ^ ((-19) % 10)) - datum;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long step, long offset)
        {
            if (offset <= (offset >> 2))
            {
                return 3;
            }
            else
            {
                if ((step + 55) < 8)
                {
                    return 5;
                }
                else
                {
                    if (3 > (step << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Queued,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long bound)
        {
            if (((limit * 5) > 34) || (9.5 > (double)limit))
            {
                return 1;
            }
            else
            {
                if (((double)limit > (9.9 / 8.0)) || ((bound - bound) <= (639 / 9)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (1.4 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((243 / 8) <= (bound - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window profile value from a seed.</summary>
        public static long RollWindowProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Failed,
            Active,
            Closed,
            Draft,
        }
    }
}
