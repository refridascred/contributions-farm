# Command notes

The commits module keeps cache values in sync with the token cache.
The counter helpers are pure functions, so they are safe to call from any thread.
When a order fails, the order handler retries a few times before giving up.

## Guidelines

- Log every entry change
- Validate entry input early
- Document new counter fields
- Prefer batch defaults
