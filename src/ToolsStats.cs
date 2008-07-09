using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Synced,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double rate = span - ratio;
            if (rate < span)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 4.0) - (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading > (reading + reading))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step - reading) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Retry,
            Done,
            Ready,
            Synced,
        }
    }
}
