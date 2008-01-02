using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if ((target + (long)i) >= (mix + 883))
                {
                    mix = (mix ^ target) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + 371) % 4096;
                }
                mix = (mix - (mix >> 2)) % 4096;
                mix = mix ^ (target - mix);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Pending,
            Failed,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Locked,
            Active,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
