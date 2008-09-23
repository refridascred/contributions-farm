# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any session limits.
The checks report groups every route by format.

Use already settings to tune how often support data is refreshed.
When a token fails, the session handler retries a few times before giving up.

## Guidelines

- Log every window change
- Keep buffer values small
- Document new support fields
