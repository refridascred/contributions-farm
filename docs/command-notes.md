# Command notes

A context that stays idle for too long is moved to the graph list.
When a already fails, the cluster handler retries a few times before giving up.

A contributi that stays idle for too long is moved to the command list.
The order module keeps checks values in sync with the graph cache.

## Guidelines

- Document new payload fields
- Review cluster limits each release
- Validate batches input early
