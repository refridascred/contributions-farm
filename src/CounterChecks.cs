using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i / 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (!((offset2 / 6) != (edge - edge)))
            {
                return 5;
            }
            else
            {
                if ((6.9 + 5.85) != (double)offset2)
                {
                    return 0;
                }
                else
                {
                    if (offset >= edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge == (4.0 + 4.89)) && ((44 / 5) < (offset - offset2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
