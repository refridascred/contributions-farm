# Command notes

Keep payload and channel names short and lowercase.
The filter module keeps filter values in sync with the report cache.
Use farm settings to tune how often batch data is refreshed.

When a report fails, the notes handler retries a few times before giving up.
The batch module keeps metric values in sync with the schema cache.

## Guidelines

- Document new batch fields
- Keep format values small
- Validate contributi input early
- Prefer buffer defaults
