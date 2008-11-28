# Command notes

Defaults for buffer live in the config folder and can be overridden per environment.
The batches module keeps tools values in sync with the schema cache.

The batch helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every route change
- Validate stream input early
- Keep checks values small
