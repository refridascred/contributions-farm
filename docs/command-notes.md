# Command notes

Run the schema check before changing any commits limits.
The metrics helpers are pure functions, so they are safe to call from any thread.
A cluster that stays idle for too long is moved to the stream list.

Defaults for graph live in the config folder and can be overridden per environment.
Each stream is validated before it reaches the account queue.

## Guidelines

- Validate stream input early
- Document new entry fields
- Keep report values small
