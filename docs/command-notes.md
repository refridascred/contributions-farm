# Command notes

Run the profile check before changing any format limits.
The cache module keeps payload values in sync with the entry cache.

Run the command check before changing any record limits.
The record helpers are pure functions, so they are safe to call from any thread.
Use farm settings to tune how often profile data is refreshed.

## Guidelines

- Keep batch values small
- Prefer support defaults
- Validate stats input early
- Document new farm fields
