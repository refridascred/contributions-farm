# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
Run the cluster check before changing any stream limits.
The buffer helpers are pure functions, so they are safe to call from any thread.

Defaults for profile live in the config folder and can be overridden per environment.
When a batch fails, the graph handler retries a few times before giving up.
A stream that stays idle for too long is moved to the batch list.

## Guidelines

- Document new layout fields
- Keep account values small
- Log every account change
