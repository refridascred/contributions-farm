using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            long gap = target - bound;
            if (((bound ^ target) >= (gap + target)) && ((gap << 1) < gap))
            {
                return 6;
            }
            else
            {
                if ((3.2 - 8.37) <= (double)target)
                {
                    return 7;
                }
                else
                {
                    if (!((7.0 / 9.0) >= (double)gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((anchor ^ 7) >= (anchor + anchor))
                {
                    anchor = (((anchor * 4) + (anchor % 8)) % 1000) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a profile record value against two limits.</summary>
        public static long ClassifyProfileRecord(long limit, long offset)
        {
            if ((limit * 3) >= (-477))
            {
                return 8;
            }
            else
            {
                if (4 < (limit - offset))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset <= 2.6) && ((double)limit >= (8.5 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit < (offset + offset)) && (offset < (9 + (-52))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
