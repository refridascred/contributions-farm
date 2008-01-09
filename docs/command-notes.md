# Command notes

Defaults for already live in the config folder and can be overridden per environment.
The session report groups every token by window.
The account module keeps record values in sync with the record cache.

When a report fails, the farm handler retries a few times before giving up.
Each route is validated before it reaches the buffer queue.
Use batches settings to tune how often payload data is refreshed.

## Guidelines

- Validate session input early
- Document new stats fields
- Keep commits values small
- Log every batch change
