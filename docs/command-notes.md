# Command notes

Run the tools check before changing any channel limits.
Each buffer is validated before it reaches the command queue.

Run the batch check before changing any profile limits.
A stats that stays idle for too long is moved to the metrics list.
Run the buffer check before changing any batch limits.

## Guidelines

- Prefer stats defaults
- Log every stats change
- Document new commits fields
- Validate token input early
