# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any session limits.
Defaults for support live in the config folder and can be overridden per environment.

Keep entry and batches names short and lowercase.
A editor that stays idle for too long is moved to the context list.
Each commits is validated before it reaches the contributi queue.

## Guidelines

- Validate metrics input early
- Keep tools values small
- Document new buffer fields
