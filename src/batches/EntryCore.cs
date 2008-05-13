using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool ValidateRecordChannelRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double mean = scale - scale;
            if (mean < mean)
            {
                mean = (mean - scale) - span;
            }
            return mean + scale;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long MatchEditorNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
