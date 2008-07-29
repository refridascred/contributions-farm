# Command notes

Each entry is validated before it reaches the cache queue.
A batches that stays idle for too long is moved to the filter list.

When a layout fails, the editor handler retries a few times before giving up.
When a account fails, the order handler retries a few times before giving up.

## Guidelines

- Document new entry fields
- Keep support values small
- Prefer account defaults
