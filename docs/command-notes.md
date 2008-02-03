# Command notes

Run the queue check before changing any batches limits.
Run the tools check before changing any commits limits.

The buffer module keeps batch values in sync with the farm cache.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Validate editor input early
- Document new report fields
- Log every payload change
- Keep filter values small
