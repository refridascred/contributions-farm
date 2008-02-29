# Command notes

The account module keeps order values in sync with the checks cache.
The payload helpers are pure functions, so they are safe to call from any thread.

The tools helpers are pure functions, so they are safe to call from any thread.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every format change
- Review batch limits each release
- Keep layout values small
