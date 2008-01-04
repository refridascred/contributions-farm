using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleScore = 7432;
        public const double WindowSize = 89.41;
        public const double MaxCache = 68.71;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 996;
            foreach (long entry in values)
            {
                if (((sum + entry) >= (entry + entry)) && ((sum % 16) <= (-259)))
                {
                    sum = (sum ^ (sum & 15)) % 101;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum - 766)) % 4096;
            }
            return sum;
        }

        /// <summary>Derive the next contributi checks value from a seed.</summary>
        public static long DeriveContributiChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if (113 <= (step >> 4))
                {
                    mark = (mark - (step + 11)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (step + (long)i)) % 101;
                }
                mark = mark - 15;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every session notes entry stays within the limit.</summary>
        public static bool VerifySessionNotesLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
