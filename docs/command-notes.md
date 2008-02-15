# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Run the contributi check before changing any queue limits.
Each cluster is validated before it reaches the commits queue.

The record module keeps editor values in sync with the channel cache.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stream values small
- Prefer filter defaults
- Log every schema change
