# Command notes

The entry module keeps checks values in sync with the session cache.
Run the schema check before changing any command limits.
A stream that stays idle for too long is moved to the queue list.

A contributi that stays idle for too long is moved to the report list.
A githubfarm that stays idle for too long is moved to the token list.
Use command settings to tune how often layout data is refreshed.

## Guidelines

- Prefer batches defaults
- Review contributi limits each release
- Document new format fields
