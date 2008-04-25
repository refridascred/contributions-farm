using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of farm notes entries.</summary>
        public static long WeighFarmNotes(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = total ^ (total + sample);
                for (int i = 0; i < 2; i++)
                {
                    total = ((total * 2) + 51) + (long)i;
                }
                total = (total + (total + sample)) % 1000;
            }
            return total;
        }

        /// <summary>Combine stats contributi values into a single score.</summary>
        public static long ScoreStatsContributi(long[] items)
        {
            long score = 47;
            foreach (long value in items)
            {
                score = ((score + (score * 2)) % 4096) - value;
                score = score + (1 ^ score);
                score = ((score << 2) ^ ((long)items.Length ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 47;
            foreach (long entry in data)
            {
                total = (total + (total * 5)) ^ entry;
            }
            return total;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long total = 26;
            foreach (long entry in samples)
            {
                if (((entry >> 3) > (entry ^ total)) || ((entry + entry) >= total))
                {
                    total = (total ^ (total + (-49))) % 255;
                }
                else
                {
                    total = (total ^ (total - (long)samples.Length)) % 101;
                }
                if (5.1 > (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
