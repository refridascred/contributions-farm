# Command notes

Use graph settings to tune how often metric data is refreshed.
Each stream is validated before it reaches the format queue.
Defaults for context live in the config folder and can be overridden per environment.

Each graph is validated before it reaches the farm queue.
The record module keeps batch values in sync with the queue cache.

## Guidelines

- Prefer queue defaults
- Keep token values small
- Document new cache fields
