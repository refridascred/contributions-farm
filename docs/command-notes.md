# Command notes

Run the notes check before changing any queue limits.
Each order is validated before it reaches the support queue.

The command module keeps tools values in sync with the graph cache.
A cluster that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep tools values small
- Validate report input early
- Prefer contributi defaults
- Log every order change
