# Command notes

Run the command check before changing any already limits.
The cache helpers are pure functions, so they are safe to call from any thread.
Each commits is validated before it reaches the farm queue.

## Guidelines

- Review checks limits each release
- Keep order values small
- Document new batch fields
- Log every format change
