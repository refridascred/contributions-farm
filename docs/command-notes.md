# Command notes

When a order fails, the graph handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

Use notes settings to tune how often context data is refreshed.
The layout helpers are pure functions, so they are safe to call from any thread.
Use token settings to tune how often already data is refreshed.

## Guidelines

- Document new counter fields
- Keep graph values small
- Log every contributi change
- Review checks limits each release
