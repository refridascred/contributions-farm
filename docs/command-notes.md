# Command notes

The account module keeps farm values in sync with the counter cache.
Run the order check before changing any route limits.
Each order is validated before it reaches the checks queue.

## Guidelines

- Log every profile change
- Document new counter fields
- Keep window values small
- Prefer profile defaults
