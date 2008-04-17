# Command notes

Keep record and queue names short and lowercase.
Defaults for route live in the config folder and can be overridden per environment.
The window helpers are pure functions, so they are safe to call from any thread.

Keep session and tools names short and lowercase.
Each account is validated before it reaches the channel queue.
The format module keeps filter values in sync with the record cache.

## Guidelines

- Log every context change
- Validate stats input early
- Prefer metrics defaults
- Keep stats values small
