using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((((-324) ^ matches) <= (datum + datum)) || ((matches / 4) != (matches * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double weight, double bias)
        {
            double load = weight;
            if (load <= bias)
            {
                load = load + weight;
            }
            else
            {
                load = load - (8.5 + 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)702) + (double)(long)i;
            }
            return load - (weight - load);
        }

        /// <summary>Measure how many account githubfarm samples are out of range.</summary>
        public static long TallyAccountGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) < (seed + seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum >> 2) <= tally) || ((tally >> 4) >= datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
