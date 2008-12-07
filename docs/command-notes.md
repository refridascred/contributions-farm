# Command notes

The metrics module keeps order values in sync with the order cache.
Run the githubfarm check before changing any account limits.

A command that stays idle for too long is moved to the metrics list.
Each report is validated before it reaches the checks queue.

## Guidelines

- Document new token fields
- Log every context change
- Prefer record defaults
- Keep farm values small
