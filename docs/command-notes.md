# Command notes

The stream module keeps metrics values in sync with the entry cache.
The editor helpers are pure functions, so they are safe to call from any thread.
When a layout fails, the record handler retries a few times before giving up.

The token module keeps payload values in sync with the report cache.
Run the buffer check before changing any session limits.
Keep command and record names short and lowercase.

## Guidelines

- Document new profile fields
- Log every context change
- Review metric limits each release
- Keep metrics values small
