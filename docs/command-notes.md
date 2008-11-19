# Command notes

Run the order check before changing any stats limits.
When a schema fails, the metrics handler retries a few times before giving up.
Use payload settings to tune how often metrics data is refreshed.

When a payload fails, the farm handler retries a few times before giving up.
Defaults for payload live in the config folder and can be overridden per environment.
The batches report groups every counter by profile.

## Guidelines

- Log every stats change
- Keep batch values small
- Validate layout input early
