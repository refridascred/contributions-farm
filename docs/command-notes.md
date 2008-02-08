# Command notes

A stream that stays idle for too long is moved to the batch list.
The support helpers are pure functions, so they are safe to call from any thread.
Use githubfarm settings to tune how often command data is refreshed.

## Guidelines

- Review batches limits each release
- Validate notes input early
- Prefer format defaults
- Document new report fields
