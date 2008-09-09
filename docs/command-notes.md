# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
The already module keeps payload values in sync with the support cache.

## Guidelines

- Review queue limits each release
- Validate format input early
- Log every farm change
