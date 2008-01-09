using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long limit)
        {
            long score = -12;
            foreach (long reading in series)
            {
                if ((limit << 1) < (reading - (long)series.Length))
                {
                    score = ((score << 2) ^ (reading / 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((entry ^ (-2)) > (matches + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftInterval = 9256;
        public const long LimitSpan = 5936;
        public const long SoftLevel = 5015;
        public const long MinFormat = 1891;
        public const long MinWidth = 6912;
    }
}
