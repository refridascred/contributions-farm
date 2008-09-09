# Command notes

When a window fails, the window handler retries a few times before giving up.
The layout module keeps batches values in sync with the context cache.

## Guidelines

- Prefer batch defaults
- Keep metric values small
- Log every stream change
