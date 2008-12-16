# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any record limits.
Run the metrics check before changing any token limits.

## Guidelines

- Log every profile change
- Validate commits input early
- Keep already values small
- Prefer queue defaults
