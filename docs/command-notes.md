# Command notes

The window module keeps schema values in sync with the support cache.
Use commits settings to tune how often order data is refreshed.

The cache helpers are pure functions, so they are safe to call from any thread.
The profile module keeps command values in sync with the already cache.

## Guidelines

- Validate order input early
- Log every notes change
- Keep context values small
- Document new schema fields
