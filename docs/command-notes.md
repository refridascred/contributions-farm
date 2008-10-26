# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
The channel helpers are pure functions, so they are safe to call from any thread.

When a context fails, the notes handler retries a few times before giving up.
Defaults for format live in the config folder and can be overridden per environment.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep cluster values small
- Log every context change
- Document new buffer fields
- Validate graph input early
