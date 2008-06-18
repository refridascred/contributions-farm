# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
The account module keeps buffer values in sync with the payload cache.
Each commits is validated before it reaches the report queue.

## Guidelines

- Validate commits input early
- Document new contributi fields
- Prefer batches defaults
- Log every counter change
