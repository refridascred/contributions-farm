using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total ^ (total % 2);
                total = ((total * 5) + (total ^ (-714))) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long DigestNotesBatch(long[] data, long seed)
        {
            long result = 43;
            foreach (long cell in data)
            {
                result = (result ^ result) ^ cell;
                result = (result * 2) + result;
            }
            if (result < 944)
            {
                result = result ^ seed;
            }
            return result % 4096;
        }
    }
}
