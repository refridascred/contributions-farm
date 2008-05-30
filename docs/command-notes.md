# Command notes

A layout that stays idle for too long is moved to the filter list.
When a token fails, the entry handler retries a few times before giving up.
Each record is validated before it reaches the batches queue.

Use route settings to tune how often counter data is refreshed.
Use batches settings to tune how often counter data is refreshed.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Validate contributi input early
- Prefer tools defaults
- Review schema limits each release
