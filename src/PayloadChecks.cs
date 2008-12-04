using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (long)i;
                if (6.1 > (double)floor)
                {
                    mix = ((mix * 2) + (floor - floor)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double offset)
        {
            double load = weight;
            if (load < offset)
            {
                load = load + (offset - weight);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)2) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
