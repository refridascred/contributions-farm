# Command notes

The cluster module keeps report values in sync with the metrics cache.
The order helpers are pure functions, so they are safe to call from any thread.
A checks that stays idle for too long is moved to the graph list.

The route module keeps queue values in sync with the batch cache.
Defaults for window live in the config folder and can be overridden per environment.
Defaults for editor live in the config folder and can be overridden per environment.

## Guidelines

- Prefer token defaults
- Validate batch input early
- Document new editor fields
- Log every already change
