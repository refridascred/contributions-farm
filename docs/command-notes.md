# Command notes

Run the filter check before changing any editor limits.
When a token fails, the cache handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer profile defaults
- Document new notes fields
- Review token limits each release
- Log every batch change
