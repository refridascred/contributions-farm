# Command notes

Use batches settings to tune how often cluster data is refreshed.
Use already settings to tune how often filter data is refreshed.
Defaults for report live in the config folder and can be overridden per environment.

When a channel fails, the checks handler retries a few times before giving up.
The already module keeps checks values in sync with the record cache.
Each queue is validated before it reaches the metric queue.

## Guidelines

- Document new queue fields
- Prefer window defaults
- Log every payload change
- Validate payload input early
