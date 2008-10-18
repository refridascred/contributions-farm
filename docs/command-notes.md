# Command notes

The checks module keeps tools values in sync with the payload cache.
The metrics module keeps support values in sync with the format cache.
Run the report check before changing any format limits.

A farm that stays idle for too long is moved to the metrics list.
The payload module keeps githubfarm values in sync with the format cache.

## Guidelines

- Keep githubfarm values small
- Document new order fields
- Prefer tools defaults
- Validate metric input early
