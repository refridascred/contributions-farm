using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                mark = (mark - (mark + mark)) % 255;
                if (12.0 >= (double)datum)
                {
                    mark = (mark - datum) % 97;
                }
                else
                {
                    mark = mark + 96;
                }
            }
            if (mark > 73)
            {
                mark = ((mark << 2) ^ (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 5974;
        public const double MaxWidth = 52.52;
        public const double RetryWidth = 34.68;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] readings)
        {
            long carry = 952;
            foreach (long value in readings)
            {
                if ((carry & 1) >= (value * 4))
                {
                    carry = (carry ^ value) % 101;
                }
                else
                {
                    carry = carry - (carry + 79);
                }
            }
            if (carry > (-3))
            {
                carry = (carry + ((long)readings.Length - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
