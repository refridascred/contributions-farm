using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LookupStreamBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long step, long offset)
        {
            long diff = step ^ offset;
            if (((offset & 7) <= offset) || ((double)offset < (double)step))
            {
                return 2;
            }
            else
            {
                if (((double)diff < 12.0) || ((3.8 / 7.0) > (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (step >= (84 ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(step <= (offset - 420)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
