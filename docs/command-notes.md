# Command notes

Run the cluster check before changing any farm limits.
Each queue is validated before it reaches the farm queue.

Keep already and format names short and lowercase.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every checks change
- Validate session input early
- Document new editor fields
- Prefer record defaults
