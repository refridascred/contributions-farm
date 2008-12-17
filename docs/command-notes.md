# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
The cache module keeps command values in sync with the buffer cache.
Use cache settings to tune how often checks data is refreshed.

## Guidelines

- Prefer stream defaults
- Document new session fields
- Validate context input early
