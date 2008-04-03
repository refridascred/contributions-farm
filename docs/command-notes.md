# Command notes

The support module keeps token values in sync with the format cache.
Run the entry check before changing any session limits.
Run the batches check before changing any counter limits.

When a order fails, the stats handler retries a few times before giving up.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Prefer filter defaults
- Validate metrics input early
- Document new commits fields
- Keep route values small
