# Command notes

The checks module keeps metric values in sync with the format cache.
Each cluster is validated before it reaches the graph queue.
A metrics that stays idle for too long is moved to the support list.

Each commits is validated before it reaches the counter queue.
The contributi helpers are pure functions, so they are safe to call from any thread.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Prefer profile defaults
- Validate batches input early
- Keep editor values small
