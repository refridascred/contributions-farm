# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
The counter module keeps channel values in sync with the farm cache.

Use cache settings to tune how often stream data is refreshed.
The filter module keeps checks values in sync with the commits cache.

## Guidelines

- Log every window change
- Validate stats input early
- Review stream limits each release
- Document new record fields
