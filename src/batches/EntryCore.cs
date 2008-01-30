using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next schema batches value from a seed.</summary>
        public static long StepSchemaBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i % 8) >= (73 << 2))
                {
                    mix = ((mix * 2) + ((long)i / 7)) % 4096;
                    break;
                }
                else
                {
                    mix = mix - (21 * 4);
                }
                mix = (mix - (origin / 5)) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + (long)samples.Length) > (matches / 4))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
