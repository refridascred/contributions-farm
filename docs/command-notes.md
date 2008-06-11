# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Run the format check before changing any route limits.
Keep already and report names short and lowercase.

A payload that stays idle for too long is moved to the order list.
Each entry is validated before it reaches the channel queue.

## Guidelines

- Document new entry fields
- Review payload limits each release
- Keep entry values small
