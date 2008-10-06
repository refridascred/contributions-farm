# Command notes

The tools report groups every stream by commits.
Each already is validated before it reaches the order queue.
When a order fails, the profile handler retries a few times before giving up.

Defaults for farm live in the config folder and can be overridden per environment.
When a order fails, the metrics handler retries a few times before giving up.

## Guidelines

- Validate graph input early
- Document new order fields
- Prefer editor defaults
