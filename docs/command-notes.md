# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
A order that stays idle for too long is moved to the tools list.
Each command is validated before it reaches the context queue.

Run the cluster check before changing any metric limits.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every contributi change
- Prefer filter defaults
- Document new buffer fields
