# Command notes

The schema module keeps channel values in sync with the token cache.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new channel fields
- Keep token values small
- Log every channel change
- Review context limits each release
