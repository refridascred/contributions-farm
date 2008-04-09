# Command notes

The command module keeps batches values in sync with the graph cache.
Run the record check before changing any notes limits.

A format that stays idle for too long is moved to the filter list.
A format that stays idle for too long is moved to the command list.
Each window is validated before it reaches the buffer queue.

## Guidelines

- Prefer entry defaults
- Document new profile fields
- Validate graph input early
- Review cluster limits each release
