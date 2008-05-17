using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long bound)
        {
            long anchor = -8;
            foreach (long item in data)
            {
                if (!(bound > (974 << 3)))
                {
                    anchor = (anchor + (bound << 3)) % 4096;
                }
                if ((anchor + item) > bound)
                {
                    anchor = anchor - (item + item);
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
