# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Defaults for report live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.

A token that stays idle for too long is moved to the schema list.
A farm that stays idle for too long is moved to the cluster list.
Run the schema check before changing any layout limits.

## Guidelines

- Prefer token defaults
- Keep metrics values small
- Document new buffer fields
