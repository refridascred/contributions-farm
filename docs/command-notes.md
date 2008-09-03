# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
Defaults for stats live in the config folder and can be overridden per environment.
Run the context check before changing any batch limits.

When a graph fails, the cluster handler retries a few times before giving up.
Keep batches and notes names short and lowercase.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review support limits each release
- Log every farm change
- Document new layout fields
