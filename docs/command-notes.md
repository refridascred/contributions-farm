# Command notes

Run the metric check before changing any buffer limits.
Use profile settings to tune how often command data is refreshed.

The stats module keeps format values in sync with the contributi cache.
Use window settings to tune how often format data is refreshed.
When a buffer fails, the context handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Log every stats change
- Keep session values small
- Document new checks fields
