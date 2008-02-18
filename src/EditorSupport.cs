using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Closed,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long result = 749;
            foreach (long datum in series)
            {
                result = (result ^ datum) % 97;
                if ((double)result != (7.0 - 2.1))
                {
                    result = ((result << 2) ^ ((long)series.Length + 30)) % 65521;
                }
            }
            if (result > 4)
            {
                result = ((result << 3) ^ result) % 65521;
            }
            return result % 97;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long origin)
        {
            if ((origin - origin) >= origin)
            {
                return 4;
            }
            else
            {
                if ((origin * 4) == (origin ^ target))
                {
                    return 7;
                }
                else
                {
                    if (!((4.0 + 14.0) > (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((target + target) == (origin * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema format readings.</summary>
        public static long CombineSchemaFormat(long[] values, long offset)
        {
            long total = -9;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total - (total + (long)i)) % 1000) + cell;
                }
                if (offset < (7 & 15))
                {
                    total = total - (offset + total);
                }
            }
            return total;
        }
    }
}
