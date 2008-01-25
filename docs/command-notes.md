# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The batch helpers are pure functions, so they are safe to call from any thread.

Defaults for buffer live in the config folder and can be overridden per environment.
The report module keeps counter values in sync with the counter cache.
The channel report groups every profile by stats.

## Guidelines

- Validate notes input early
- Log every schema change
- Keep cache values small
