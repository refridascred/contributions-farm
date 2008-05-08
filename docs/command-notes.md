# Command notes

The batch module keeps batches values in sync with the profile cache.
Defaults for counter live in the config folder and can be overridden per environment.

A stats that stays idle for too long is moved to the stats list.
Each metrics is validated before it reaches the queue queue.

## Guidelines

- Document new window fields
- Log every window change
- Prefer filter defaults
- Validate layout input early
