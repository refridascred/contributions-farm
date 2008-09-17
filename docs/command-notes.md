# Command notes

The metrics module keeps account values in sync with the contributi cache.
A token that stays idle for too long is moved to the stats list.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stream limits each release
- Keep token values small
- Document new account fields
- Validate buffer input early
