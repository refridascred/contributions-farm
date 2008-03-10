# Command notes

Run the filter check before changing any buffer limits.
Use cache settings to tune how often graph data is refreshed.
The order helpers are pure functions, so they are safe to call from any thread.

The notes helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps queue values in sync with the session cache.

## Guidelines

- Review checks limits each release
- Validate format input early
- Document new counter fields
- Log every payload change
