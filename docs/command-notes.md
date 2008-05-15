# Command notes

Each record is validated before it reaches the cache queue.
A farm that stays idle for too long is moved to the support list.
A notes that stays idle for too long is moved to the format list.

Run the tools check before changing any counter limits.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Review stats limits each release
- Validate buffer input early
- Keep cluster values small
- Prefer channel defaults
