# Command notes

The cluster module keeps report values in sync with the commits cache.
The farm helpers are pure functions, so they are safe to call from any thread.

Use order settings to tune how often batches data is refreshed.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Review command limits each release
- Validate graph input early
- Log every window change
- Prefer format defaults
