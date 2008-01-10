# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Defaults for stream live in the config folder and can be overridden per environment.

When a entry fails, the session handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer queue defaults
- Validate batches input early
- Document new tools fields
