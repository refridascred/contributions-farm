# Command notes

A context that stays idle for too long is moved to the farm list.
The filter module keeps checks values in sync with the githubfarm cache.
When a graph fails, the support handler retries a few times before giving up.

A farm that stays idle for too long is moved to the metrics list.
Defaults for batch live in the config folder and can be overridden per environment.
The stats report groups every payload by record.

## Guidelines

- Review batches limits each release
- Prefer queue defaults
- Log every cluster change
- Validate command input early
