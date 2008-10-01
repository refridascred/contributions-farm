# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
Each cache is validated before it reaches the batches queue.
Run the farm check before changing any metric limits.

A account that stays idle for too long is moved to the channel list.
Run the filter check before changing any cache limits.

## Guidelines

- Document new graph fields
- Keep cluster values small
- Review account limits each release
- Validate tools input early
