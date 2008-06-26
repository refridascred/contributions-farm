using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                if ((double)0 <= (double)reading)
                {
                    sum = (sum ^ (reading / 6)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - target) > ((long)samples.Length * 5))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long floor)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                if ((double)mix < (9.9 / 5.0))
                {
                    mix = ((mix * 2) + floor) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix ^ reading)) % 4096;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + reading) % 255) + (long)i;
                    mix = ((mix * 4) + (reading + floor)) % 255;
                }
                mix = ((mix << 2) ^ (5 ^ mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Locked,
            Paused,
            Queued,
            Done,
        }
    }
}
