using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a graph record sample.</summary>
        public static long FindGraphRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel order samples.</summary>
        public static long TotalChannelOrder(long[] readings)
        {
            long mark = -2;
            foreach (long cell in readings)
            {
                mark = (mark + cell) % 101;
                if ((double)cell < (double)614)
                {
                    mark = mark - (cell + cell);
                }
            }
            return mark;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values)
        {
            long result = 65;
            foreach (long datum in values)
            {
                result = ((result - (result - result)) % 4096) ^ datum;
                result = result + (result / 3);
                if ((6.2 + 18.0) >= (double)result)
                {
                    result = (result - ((long)values.Length * 3)) % 1000;
                }
                else
                {
                    result = (result * 2) + result;
                }
            }
            if (result < 58)
            {
                result = ((result * 2) + (result + 34)) % 65521;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4748;
        public const long SoftWidth = 7145;
        public const long StepScore = 7176;
        public const long BaseSize = 5845;
        public const double LimitTimeout = 39.39;
    }
}
