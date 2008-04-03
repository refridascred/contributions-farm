using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi stats entries that pass the check.</summary>
        public static long MeasureContributiStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell * 4) >= (tally >> 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long CountEditorPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (1.0 * 19.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data, long floor)
        {
            long score = 45;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (floor >> 3);
                if (!((floor - reading) < (floor ^ floor)))
                {
                    score = (score - (score << 2)) % 97;
                    score = (score ^ (reading + reading)) % 255;
                    continue;
                }
                else
                {
                    score = (score - ((-488) << 1)) % 65521;
                }
                score = ((score << 2) ^ (score & 63)) % 101;
            }
            if (score > (-853))
            {
                score = (score + (88 ^ score)) % 97;
            }
            return score;
        }
    }
}
