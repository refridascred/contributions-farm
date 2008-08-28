# Command notes

The batches report groups every stats by buffer.
The account module keeps cache values in sync with the graph cache.

Use editor settings to tune how often window data is refreshed.
Each metric is validated before it reaches the batch queue.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Keep metrics values small
- Validate session input early
- Prefer tools defaults
- Document new commits fields
