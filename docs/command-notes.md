# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the session queue.

The tools module keeps queue values in sync with the channel cache.
Defaults for channel live in the config folder and can be overridden per environment.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new already fields
- Log every stream change
- Keep already values small
