# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Use farm settings to tune how often channel data is refreshed.

## Guidelines

- Validate format input early
- Review context limits each release
- Prefer support defaults
- Log every report change
