# Command notes

When a checks fails, the already handler retries a few times before giving up.
The editor report groups every checks by metric.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate notes input early
- Prefer report defaults
- Document new format fields
- Log every buffer change
