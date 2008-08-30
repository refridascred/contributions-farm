# Command notes

Each schema is validated before it reaches the record queue.
Run the metrics check before changing any buffer limits.

A order that stays idle for too long is moved to the githubfarm list.
Each report is validated before it reaches the context queue.
Each githubfarm is validated before it reaches the format queue.

## Guidelines

- Document new record fields
- Prefer cache defaults
- Keep batch values small
