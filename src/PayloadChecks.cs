using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long DeriveGithubfarmRoute(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i * 5) <= (step + anchor))
                {
                    anchor = (anchor + (step / 2)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long DigestBufferCounter(long[] readings)
        {
            long anchor = 12;
            foreach (long sample in readings)
            {
                anchor = (anchor + sample) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data, long origin)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = ((((state << 2) ^ 3) % 101) ^ reading) - origin;
            }
            return state % 1000;
        }

        /// <summary>Check that every notes batch entry stays within the limit.</summary>
        public static bool VerifyNotesBatchBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-99) % 100) <= (bound & 63))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
