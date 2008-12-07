using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Combine checks account values into a single score.</summary>
        public static long CombineChecksAccount(long[] items, long origin)
        {
            long mark = 496;
            foreach (long sample in items)
            {
                if (!((mark & 1) != (sample << 2)))
                {
                    mark = (mark + sample) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (origin & 255);
                }
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long carry = -2;
            foreach (long datum in samples)
            {
                if ((507 & 15) < datum)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + (datum + carry)) % 101;
                }
                carry = (carry + (carry << 2)) % 101;
            }
            if (carry > 64)
            {
                carry = (carry << 2) ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] data)
        {
            long score = 529;
            foreach (long value in data)
            {
                score = ((score << 2) ^ (value / 3)) % 255;
                if (!((score >> 2) < value))
                {
                    long lane = value ^ 912;
                    score = score - ((long)data.Length ^ lane);
                }
                if ((value / 7) < ((-62) + score))
                {
                    score = (score * 3) + value;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((step & 127) > (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Dropped,
            Locked,
            New,
            Synced,
        }
    }
}
