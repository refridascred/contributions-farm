# Command notes

A farm that stays idle for too long is moved to the command list.
Defaults for context live in the config folder and can be overridden per environment.
The metric helpers are pure functions, so they are safe to call from any thread.

The format report groups every counter by batches.
Use stream settings to tune how often stats data is refreshed.
A support that stays idle for too long is moved to the command list.

## Guidelines

- Validate batch input early
- Review order limits each release
- Log every stats change
- Prefer session defaults
