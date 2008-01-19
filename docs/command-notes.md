# Command notes

Each report is validated before it reaches the stats queue.
The session module keeps checks values in sync with the metrics cache.
A channel that stays idle for too long is moved to the command list.

Defaults for stream live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the route handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Review tools limits each release
- Prefer graph defaults
- Log every counter change
