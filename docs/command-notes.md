# Command notes

The order module keeps metrics values in sync with the support cache.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review entry limits each release
- Log every farm change
- Keep order values small
