# Command notes

A checks that stays idle for too long is moved to the context list.
Keep cluster and channel names short and lowercase.
Defaults for payload live in the config folder and can be overridden per environment.

The profile report groups every farm by stream.
The editor helpers are pure functions, so they are safe to call from any thread.
Each farm is validated before it reaches the counter queue.

## Guidelines

- Log every context change
- Keep stream values small
- Prefer notes defaults
- Document new farm fields
