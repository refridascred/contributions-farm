# Command notes

Run the order check before changing any githubfarm limits.
Each githubfarm is validated before it reaches the order queue.
When a report fails, the batches handler retries a few times before giving up.

A batch that stays idle for too long is moved to the entry list.
The contributi module keeps stats values in sync with the cache cache.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Log every farm change
- Validate queue input early
- Keep graph values small
- Document new already fields
