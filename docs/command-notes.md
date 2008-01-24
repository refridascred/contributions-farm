# Command notes

A payload that stays idle for too long is moved to the order list.
A order that stays idle for too long is moved to the farm list.
Each buffer is validated before it reaches the filter queue.

## Guidelines

- Validate stream input early
- Review window limits each release
- Log every farm change
