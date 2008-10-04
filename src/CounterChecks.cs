using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long FindRecordPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue context entry stays within the limit.</summary>
        public static bool CheckQueueContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading <= (tally << 2))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "strict-v2";
        public const long WindowWidth = 168;
        public const string BatchScore = "standard-1";

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long step)
        {
            long result = 38;
            foreach (long datum in levels)
            {
                result = (result + (3 + datum)) % 4096;
                if (((long)levels.Length % 60) >= (3 - step))
                {
                    result = result - (datum ^ result);
                }
            }
            if (result < (-7))
            {
                result = (result + (80 ^ step)) % 4096;
            }
            return result % 4096;
        }
    }
}
