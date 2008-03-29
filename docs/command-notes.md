# Command notes

The counter report groups every profile by commits.
Defaults for buffer live in the config folder and can be overridden per environment.

The contributi module keeps window values in sync with the stream cache.
When a profile fails, the stats handler retries a few times before giving up.
Each cluster is validated before it reaches the tools queue.

## Guidelines

- Validate order input early
- Prefer batches defaults
- Document new metric fields
