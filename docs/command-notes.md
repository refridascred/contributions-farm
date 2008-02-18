# Command notes

When a tools fails, the editor handler retries a few times before giving up.
A window that stays idle for too long is moved to the layout list.
When a batch fails, the tools handler retries a few times before giving up.

Keep report and metric names short and lowercase.
Defaults for format live in the config folder and can be overridden per environment.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every token change
- Document new context fields
- Prefer payload defaults
- Keep profile values small
