# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
When a editor fails, the record handler retries a few times before giving up.
Use stream settings to tune how often profile data is refreshed.

## Guidelines

- Keep cluster values small
- Log every batches change
- Review profile limits each release
- Prefer filter defaults
