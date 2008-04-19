# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
When a stream fails, the profile handler retries a few times before giving up.
Run the report check before changing any report limits.

Run the stats check before changing any support limits.
Use counter settings to tune how often context data is refreshed.
When a editor fails, the support handler retries a few times before giving up.

## Guidelines

- Validate stats input early
- Review window limits each release
- Document new filter fields
