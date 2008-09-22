# Command notes

When a channel fails, the checks handler retries a few times before giving up.
Keep session and queue names short and lowercase.
Each session is validated before it reaches the layout queue.

Each format is validated before it reaches the stream queue.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Document new report fields
- Validate notes input early
- Prefer report defaults
