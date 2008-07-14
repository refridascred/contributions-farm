# Command notes

A buffer that stays idle for too long is moved to the farm list.
The metric helpers are pure functions, so they are safe to call from any thread.
Defaults for commits live in the config folder and can be overridden per environment.

A notes that stays idle for too long is moved to the cluster list.
Each entry is validated before it reaches the window queue.
Each counter is validated before it reaches the batch queue.

## Guidelines

- Validate tools input early
- Prefer stream defaults
- Log every metrics change
