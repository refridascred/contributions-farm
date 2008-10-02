# Command notes

Run the payload check before changing any account limits.
The payload module keeps graph values in sync with the record cache.
A checks that stays idle for too long is moved to the token list.

## Guidelines

- Review context limits each release
- Keep format values small
- Validate batches input early
- Prefer record defaults
