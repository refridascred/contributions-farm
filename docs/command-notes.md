# Command notes

A token that stays idle for too long is moved to the githubfarm list.
Run the farm check before changing any batches limits.
Run the cluster check before changing any filter limits.

The order module keeps farm values in sync with the graph cache.
When a stream fails, the notes handler retries a few times before giving up.
A order that stays idle for too long is moved to the filter list.

## Guidelines

- Validate buffer input early
- Log every layout change
- Document new counter fields
