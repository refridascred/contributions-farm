# Command notes

Use tools settings to tune how often schema data is refreshed.
Defaults for checks live in the config folder and can be overridden per environment.

Each record is validated before it reaches the counter queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review token limits each release
- Log every cluster change
- Prefer support defaults
- Validate stats input early
