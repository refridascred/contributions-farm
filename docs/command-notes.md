# Command notes

The batches module keeps filter values in sync with the schema cache.
Each payload is validated before it reaches the payload queue.
Run the filter check before changing any metrics limits.

## Guidelines

- Validate profile input early
- Document new schema fields
- Prefer counter defaults
