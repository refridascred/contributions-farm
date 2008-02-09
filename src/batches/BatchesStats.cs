using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (0.4 > (double)seen)
                {
                    seen = ((seen + 2) ^ value) - target;
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm profile pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long step)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor - anchor) % 4096) + (long)i;
                }
                if (value >= step)
                {
                    anchor = (anchor + (value & 127)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
