using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine commits session values into a single score.</summary>
        public static long TotalCommitsSession(long[] readings, long step)
        {
            long anchor = 289;
            foreach (long value in readings)
            {
                anchor = anchor ^ (38 ^ value);
                if ((anchor % 3) == (step % 8))
                {
                    break;
                }
            }
            if (anchor > 330)
            {
                anchor = (anchor ^ (step - step)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = score - bound;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a editor notes sample.</summary>
        public static long FindEditorNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
