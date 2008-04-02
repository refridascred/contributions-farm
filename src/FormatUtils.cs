using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen <= (origin & 31))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Match up notes support samples.</summary>
        public static long OverlapNotesSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long result = 50;
            foreach (long entry in items)
            {
                if ((result + result) <= (result - result))
                {
                    result = ((result << 3) ^ (717 * 2)) - entry;
                }
            }
            return result;
        }

        /// <summary>Combine notes record values into a single score.</summary>
        public static long TotalNotesRecord(long[] readings)
        {
            long acc = 188;
            foreach (long entry in readings)
            {
                acc = ((acc << 3) ^ (704 - acc)) % 255;
                if ((acc - entry) > acc)
                {
                    acc = ((acc * 2) + (entry / 7)) % 97;
                    acc = acc ^ (entry + entry);
                }
                if (((acc + acc) > (entry & 3)) || (acc < (entry + acc)))
                {
                    acc = (acc - (59 % 10)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (acc + 36)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
