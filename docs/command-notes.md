# Command notes

The window module keeps command values in sync with the window cache.
Each route is validated before it reaches the schema queue.
Each metrics is validated before it reaches the counter queue.

## Guidelines

- Keep report values small
- Review farm limits each release
- Log every metrics change
- Prefer farm defaults
