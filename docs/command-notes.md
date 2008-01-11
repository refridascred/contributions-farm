# Command notes

Use report settings to tune how often command data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.
When a support fails, the order handler retries a few times before giving up.

Each notes is validated before it reaches the farm queue.
Each metrics is validated before it reaches the commits queue.

## Guidelines

- Keep metrics values small
- Document new batches fields
- Prefer support defaults
- Validate checks input early
