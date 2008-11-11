# Command notes

Each graph is validated before it reaches the metric queue.
Keep counter and format names short and lowercase.
Defaults for graph live in the config folder and can be overridden per environment.

Use metrics settings to tune how often notes data is refreshed.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cache input early
- Review farm limits each release
- Log every stats change
- Keep context values small
