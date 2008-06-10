# Command notes

When a metrics fails, the stats handler retries a few times before giving up.
Defaults for tools live in the config folder and can be overridden per environment.
Each queue is validated before it reaches the editor queue.

Each session is validated before it reaches the order queue.
Keep command and command names short and lowercase.
Each contributi is validated before it reaches the stream queue.

## Guidelines

- Validate support input early
- Prefer commits defaults
- Log every command change
- Document new commits fields
