# Command notes

When a metric fails, the order handler retries a few times before giving up.
A entry that stays idle for too long is moved to the metrics list.
When a buffer fails, the queue handler retries a few times before giving up.

## Guidelines

- Document new tools fields
- Validate tools input early
- Log every order change
