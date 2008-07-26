using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count checks cache pairs that satisfy a relation.</summary>
        public static long CompareChecksCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            long gap = origin - bound;
            if ((76 % 24) <= gap)
            {
                return 6;
            }
            else
            {
                if ((origin + origin) != (origin + gap))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) >= (gap & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (3.7 + 18.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
