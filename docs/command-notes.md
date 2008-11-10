# Command notes

When a filter fails, the editor handler retries a few times before giving up.
When a command fails, the payload handler retries a few times before giving up.

Run the buffer check before changing any session limits.
The schema module keeps cache values in sync with the support cache.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metric change
- Validate route input early
- Review format limits each release
