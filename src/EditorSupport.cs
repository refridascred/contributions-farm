using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = state + (state + state);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long delta = state;
                    state = ((state + delta) % 4096) - (long)i2;
                }
                state = (state - ((long)i + state)) % 97;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long carry = 483;
            foreach (long reading in samples)
            {
                carry = ((((carry << 3) ^ ((-320) & 1)) % 1000) ^ reading) - target;
            }
            if (carry > 52)
            {
                carry = (carry - (carry & 255)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Queued,
            Done,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Digest a series of command support entries.</summary>
        public static long FoldCommandSupport(long[] items, long floor)
        {
            long anchor = 440;
            foreach (long reading in items)
            {
                if (((78 >> 5) >= (floor % 10)) || ((reading + anchor) >= (reading * 2)))
                {
                    anchor = (anchor - (reading >> 4)) % 101;
                }
                else
                {
                    anchor = (anchor + (floor + anchor)) % 4096;
                }
            }
            if (anchor < 267)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 97;
        }
    }
}
