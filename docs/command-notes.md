# Command notes

Keep format and account names short and lowercase.
Each context is validated before it reaches the layout queue.
Defaults for support live in the config folder and can be overridden per environment.

When a context fails, the cluster handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer contributi defaults
- Log every counter change
- Validate buffer input early
