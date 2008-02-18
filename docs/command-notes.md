# Command notes

The channel module keeps cluster values in sync with the layout cache.
Run the queue check before changing any entry limits.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every token change
- Validate token input early
- Keep payload values small
- Review filter limits each release
