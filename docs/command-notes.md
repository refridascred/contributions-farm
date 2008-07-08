# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
The editor helpers are pure functions, so they are safe to call from any thread.
The filter module keeps cache values in sync with the entry cache.

## Guidelines

- Review editor limits each release
- Prefer schema defaults
- Log every order change
