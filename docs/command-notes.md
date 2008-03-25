# Command notes

Run the route check before changing any schema limits.
The session module keeps graph values in sync with the checks cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every command change
- Review session limits each release
- Prefer checks defaults
