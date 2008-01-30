# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
A format that stays idle for too long is moved to the metrics list.
The token module keeps counter values in sync with the batch cache.

The contributi helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the graph queue.

## Guidelines

- Prefer record defaults
- Log every channel change
- Keep format values small
- Validate editor input early
