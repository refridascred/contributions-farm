# Command notes

Each batch is validated before it reaches the buffer queue.
The batch module keeps checks values in sync with the context cache.

## Guidelines

- Log every window change
- Validate cache input early
- Keep commits values small
- Document new filter fields
