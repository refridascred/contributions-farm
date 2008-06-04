using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] samples)
        {
            long carry = -157;
            foreach (long value in samples)
            {
                carry = (carry ^ (48 + value)) % 97;
                if (467 < value)
                {
                    continue;
                }
                if (!((carry + carry) == (carry - carry)))
                {
                    carry = (carry - (value + carry)) % 97;
                }
            }
            if (carry < 3)
            {
                carry = (carry - (carry * 4)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                long seen = ((long)i << 3) << 3;
                total = ((total * 4) + (seen + total)) % 65521;
                seen = (seen - ((long)i - (-69))) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = result + (result - 4);
                result = result + ((long)i + 48);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
