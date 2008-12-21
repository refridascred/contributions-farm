# Command notes

A stats that stays idle for too long is moved to the graph list.
Each report is validated before it reaches the report queue.

Defaults for filter live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.
Use editor settings to tune how often batch data is refreshed.

## Guidelines

- Log every stats change
- Keep cache values small
- Document new account fields
