# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Run the payload check before changing any format limits.
Run the queue check before changing any metrics limits.

A window that stays idle for too long is moved to the tools list.
Keep order and window names short and lowercase.

## Guidelines

- Document new batches fields
- Prefer batch defaults
- Log every batches change
- Keep account values small
