# Command notes

The context module keeps command values in sync with the order cache.
The editor report groups every already by batch.

The filter report groups every cache by stats.
A order that stays idle for too long is moved to the entry list.
When a stream fails, the batches handler retries a few times before giving up.

## Guidelines

- Log every notes change
- Prefer session defaults
- Keep order values small
- Validate graph input early
