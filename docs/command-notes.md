# Command notes

When a graph fails, the record handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.
Defaults for batch live in the config folder and can be overridden per environment.

Use batches settings to tune how often cluster data is refreshed.
Each graph is validated before it reaches the report queue.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Keep command values small
- Review window limits each release
- Document new githubfarm fields
