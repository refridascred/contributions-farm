# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Use farm settings to tune how often stream data is refreshed.
Use report settings to tune how often report data is refreshed.

A channel that stays idle for too long is moved to the report list.
Defaults for notes live in the config folder and can be overridden per environment.
Each filter is validated before it reaches the route queue.

## Guidelines

- Validate stream input early
- Document new graph fields
- Log every batch change
