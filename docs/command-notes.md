# Command notes

Each payload is validated before it reaches the stream queue.
Run the counter check before changing any cache limits.

Each format is validated before it reaches the channel queue.
Each stats is validated before it reaches the metrics queue.

## Guidelines

- Prefer record defaults
- Validate session input early
- Log every layout change
