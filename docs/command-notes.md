# Command notes

Each notes is validated before it reaches the batches queue.
The window helpers are pure functions, so they are safe to call from any thread.
Use command settings to tune how often profile data is refreshed.

## Guidelines

- Prefer counter defaults
- Keep filter values small
- Log every metrics change
