# Command notes

Each graph is validated before it reaches the order queue.
Keep layout and checks names short and lowercase.
When a stream fails, the batches handler retries a few times before giving up.

The cache module keeps notes values in sync with the queue cache.
Defaults for session live in the config folder and can be overridden per environment.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Document new batch fields
- Log every record change
- Keep editor values small
- Review graph limits each release
