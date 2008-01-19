# Command notes

Keep command and contributi names short and lowercase.
Run the notes check before changing any profile limits.

The queue helpers are pure functions, so they are safe to call from any thread.
The profile report groups every route by cache.
The editor report groups every contributi by farm.

## Guidelines

- Review report limits each release
- Prefer stream defaults
- Validate context input early
- Log every cache change
