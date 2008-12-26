# Command notes

Each metric is validated before it reaches the schema queue.
Defaults for batch live in the config folder and can be overridden per environment.
A schema that stays idle for too long is moved to the batch list.

The buffer module keeps contributi values in sync with the stats cache.
Run the commits check before changing any githubfarm limits.
When a commits fails, the graph handler retries a few times before giving up.

## Guidelines

- Review tools limits each release
- Document new counter fields
- Log every entry change
