using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry tools entries.</summary>
        public static long FoldEntryTools(long[] readings, long limit)
        {
            long mix = 636;
            foreach (long cell in readings)
            {
                if (cell <= (limit << 1))
                {
                    mix = (mix * 3) + (cell & 3);
                }
                else
                {
                    mix = ((mix * 4) + (mix - 568)) % 65521;
                }
            }
            if (mix > (-7))
            {
                mix = (mix << 3) ^ limit;
            }
            return mix;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Match up window notes samples.</summary>
        public static long PairWindowNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
