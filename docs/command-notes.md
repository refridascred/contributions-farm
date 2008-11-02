# Command notes

Run the counter check before changing any metrics limits.
Run the checks check before changing any channel limits.

Use layout settings to tune how often stream data is refreshed.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate graph input early
- Log every entry change
- Prefer cache defaults
