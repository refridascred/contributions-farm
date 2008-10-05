# Command notes

Run the record check before changing any graph limits.
Each schema is validated before it reaches the token queue.

Run the token check before changing any layout limits.
Run the filter check before changing any metrics limits.
Each window is validated before it reaches the order queue.

## Guidelines

- Validate stream input early
- Log every graph change
- Document new schema fields
