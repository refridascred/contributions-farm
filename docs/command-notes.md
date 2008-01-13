# Command notes

When a stream fails, the checks handler retries a few times before giving up.
Keep report and counter names short and lowercase.
Keep route and metric names short and lowercase.

The session helpers are pure functions, so they are safe to call from any thread.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Prefer session defaults
- Document new report fields
- Keep metric values small
- Log every payload change
