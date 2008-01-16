# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Keep tools and layout names short and lowercase.
Run the format check before changing any cluster limits.

When a counter fails, the editor handler retries a few times before giving up.
When a context fails, the batch handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review window limits each release
- Validate schema input early
- Prefer filter defaults
