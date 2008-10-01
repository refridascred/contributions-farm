# Command notes

The support report groups every support by queue.
A order that stays idle for too long is moved to the tools list.

The graph module keeps account values in sync with the notes cache.
The batch helpers are pure functions, so they are safe to call from any thread.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Log every filter change
- Keep filter values small
- Validate report input early
