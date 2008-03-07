# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Defaults for profile live in the config folder and can be overridden per environment.
The record report groups every batches by context.

Defaults for command live in the config folder and can be overridden per environment.
When a report fails, the contributi handler retries a few times before giving up.
Use channel settings to tune how often queue data is refreshed.

## Guidelines

- Keep batch values small
- Validate already input early
- Log every tools change
