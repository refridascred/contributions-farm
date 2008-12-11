# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.
Each editor is validated before it reaches the batch queue.

## Guidelines

- Validate editor input early
- Document new layout fields
- Log every support change
