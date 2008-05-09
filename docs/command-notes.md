# Command notes

The editor module keeps metric values in sync with the batch cache.
A payload that stays idle for too long is moved to the stream list.
Each cache is validated before it reaches the command queue.

## Guidelines

- Log every token change
- Validate channel input early
- Document new route fields
- Prefer schema defaults
