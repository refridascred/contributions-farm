# Command notes

Each channel is validated before it reaches the support queue.
Each filter is validated before it reaches the report queue.
A notes that stays idle for too long is moved to the counter list.

A stats that stays idle for too long is moved to the context list.
The batches module keeps record values in sync with the format cache.

## Guidelines

- Review context limits each release
- Prefer farm defaults
- Document new batches fields
