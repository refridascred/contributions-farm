# Command notes

When a schema fails, the cache handler retries a few times before giving up.
A session that stays idle for too long is moved to the cache list.
Keep context and commits names short and lowercase.

Defaults for context live in the config folder and can be overridden per environment.
Run the support check before changing any route limits.

## Guidelines

- Prefer buffer defaults
- Validate notes input early
- Document new channel fields
- Log every batches change
