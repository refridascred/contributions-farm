# Command notes

Each session is validated before it reaches the window queue.
The already helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the batch list.

## Guidelines

- Log every cache change
- Review commits limits each release
- Prefer queue defaults
