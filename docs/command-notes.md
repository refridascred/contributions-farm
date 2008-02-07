# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
Each metric is validated before it reaches the window queue.
Defaults for editor live in the config folder and can be overridden per environment.

Use graph settings to tune how often batch data is refreshed.
When a tools fails, the order handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Review metric limits each release
- Log every window change
- Document new queue fields
