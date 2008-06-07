# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The account module keeps schema values in sync with the checks cache.

## Guidelines

- Review profile limits each release
- Log every payload change
- Keep editor values small
