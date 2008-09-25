# Command notes

The cluster module keeps schema values in sync with the farm cache.
Each counter is validated before it reaches the channel queue.
Each entry is validated before it reaches the profile queue.

When a support fails, the batch handler retries a few times before giving up.
Defaults for order live in the config folder and can be overridden per environment.
Each metric is validated before it reaches the metrics queue.

## Guidelines

- Document new support fields
- Keep account values small
- Log every schema change
