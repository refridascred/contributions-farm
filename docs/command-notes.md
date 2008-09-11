# Command notes

Use token settings to tune how often editor data is refreshed.
The schema module keeps contributi values in sync with the payload cache.

Use layout settings to tune how often contributi data is refreshed.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every account change
- Validate tools input early
- Keep payload values small
- Prefer report defaults
