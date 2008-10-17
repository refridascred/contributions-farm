using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Failed,
            Stale,
            Done,
            New,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] data)
        {
            long state = 873;
            foreach (long reading in data)
            {
                if ((double)reading <= (10.0 + 15.0))
                {
                    state = ((state * 3) + (state & 15)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long score = 51;
            foreach (long datum in series)
            {
                score = (((score << 2) ^ (score / 3)) % 1000) - datum;
            }
            if (score < 1)
            {
                score = score ^ (score / 5);
            }
            return score % 97;
        }
    }
}
