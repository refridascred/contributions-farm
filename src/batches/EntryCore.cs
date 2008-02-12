using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every farm queue entry stays within the limit.</summary>
        public static bool CheckFarmQueueBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up account order samples.</summary>
        public static long CompareAccountOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell == (3.0 / 9.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
