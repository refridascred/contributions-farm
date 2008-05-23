# Command notes

The record module keeps channel values in sync with the batch cache.
When a tools fails, the cache handler retries a few times before giving up.
The command report groups every window by layout.

## Guidelines

- Keep layout values small
- Log every session change
- Document new metric fields
