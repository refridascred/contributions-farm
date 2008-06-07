# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The command helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps report values in sync with the batch cache.

Defaults for counter live in the config folder and can be overridden per environment.
Run the cluster check before changing any order limits.
Each metric is validated before it reaches the notes queue.

## Guidelines

- Log every metric change
- Validate layout input early
- Keep counter values small
