# Command notes

Use batches settings to tune how often metric data is refreshed.
Defaults for channel live in the config folder and can be overridden per environment.
Each channel is validated before it reaches the filter queue.

Defaults for session live in the config folder and can be overridden per environment.
The notes module keeps checks values in sync with the queue cache.

## Guidelines

- Keep counter values small
- Review format limits each release
- Document new layout fields
