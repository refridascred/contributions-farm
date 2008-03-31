# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Use cache settings to tune how often batch data is refreshed.
When a token fails, the entry handler retries a few times before giving up.

## Guidelines

- Log every schema change
- Review already limits each release
- Document new farm fields
