using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long offset)
        {
            long state = 61;
            foreach (long value in levels)
            {
                state = ((state + (offset - 711)) % 255) + value;
                if (((long)levels.Length & 127) != (offset + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next token stream value from a seed.</summary>
        public static long DeriveTokenStream(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (bound << 3)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double drift = bias;
            if (drift <= bias)
            {
                drift = (drift + (double)490) - offset;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (double)90;
        }

        /// <summary>Fold a list of counter record readings.</summary>
        public static long FoldCounterRecord(long[] samples)
        {
            long anchor = 4;
            foreach (long value in samples)
            {
                if ((-816) <= (anchor - 499))
                {
                    anchor = (((anchor * 3) + (anchor / 8)) % 97) - value;
                }
            }
            if (anchor > 16)
            {
                anchor = anchor - (5 + (-84));
            }
            return anchor;
        }
    }
}
