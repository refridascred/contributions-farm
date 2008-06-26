# Command notes

A command that stays idle for too long is moved to the filter list.
When a stream fails, the batch handler retries a few times before giving up.
The record module keeps window values in sync with the format cache.

## Guidelines

- Prefer metrics defaults
- Log every entry change
- Document new support fields
