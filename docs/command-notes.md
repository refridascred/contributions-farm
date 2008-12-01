# Command notes

The report report groups every batch by account.
The entry module keeps checks values in sync with the entry cache.
A editor that stays idle for too long is moved to the tools list.

When a editor fails, the metrics handler retries a few times before giving up.
When a graph fails, the batch handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Document new metric fields
- Validate cluster input early
