using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long carry = 392;
            foreach (long cell in data)
            {
                carry = carry + (cell & 7);
            }
            return carry;
        }

        /// <summary>Combine order stream values into a single score.</summary>
        public static long WeighOrderStream(long[] series, long step)
        {
            long score = 237;
            foreach (long reading in series)
            {
                score = ((score - 20) % 255) + reading;
            }
            if (score > 623)
            {
                score = ((score * 4) + (step / 6)) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next editor already value from a seed.</summary>
        public static long DeriveEditorAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit record payload readings against a rule.</summary>
        public static long TallyRecordPayloadGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((25 * 4) != (seen % 2))
                {
                    seen = ((seen + 2) - sample) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9.07 * 0.1) != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
