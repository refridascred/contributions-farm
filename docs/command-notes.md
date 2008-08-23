# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Each window is validated before it reaches the schema queue.

The format report groups every batches by stats.
When a filter fails, the already handler retries a few times before giving up.

## Guidelines

- Keep route values small
- Prefer contributi defaults
- Document new editor fields
