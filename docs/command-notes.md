# Command notes

The checks module keeps format values in sync with the report cache.
The stats helpers are pure functions, so they are safe to call from any thread.
Run the report check before changing any support limits.

## Guidelines

- Review checks limits each release
- Document new payload fields
- Log every record change
