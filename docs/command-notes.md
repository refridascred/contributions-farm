# Command notes

Each token is validated before it reaches the layout queue.
Run the tools check before changing any support limits.
Defaults for counter live in the config folder and can be overridden per environment.

Keep graph and window names short and lowercase.
The payload helpers are pure functions, so they are safe to call from any thread.
When a channel fails, the record handler retries a few times before giving up.

## Guidelines

- Prefer cluster defaults
- Keep batch values small
- Document new cluster fields
