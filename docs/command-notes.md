# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the route handler retries a few times before giving up.
The channel report groups every format by order.

Use metric settings to tune how often stream data is refreshed.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Validate buffer input early
- Keep contributi values small
- Log every batch change
