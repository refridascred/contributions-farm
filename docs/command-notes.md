# Command notes

Run the entry check before changing any token limits.
The cluster helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the context list.

## Guidelines

- Keep order values small
- Document new buffer fields
- Prefer queue defaults
