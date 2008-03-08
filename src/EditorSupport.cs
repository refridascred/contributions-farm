using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + limit) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
