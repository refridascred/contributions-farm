# Command notes

The payload module keeps schema values in sync with the metric cache.
Use counter settings to tune how often account data is refreshed.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stream values small
- Document new notes fields
- Review format limits each release
- Validate batches input early
