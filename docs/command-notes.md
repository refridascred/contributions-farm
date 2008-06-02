# Command notes

The contributi report groups every payload by schema.
A metrics that stays idle for too long is moved to the stream list.
Each tools is validated before it reaches the stats queue.

Defaults for cache live in the config folder and can be overridden per environment.
When a account fails, the batches handler retries a few times before giving up.
Keep entry and metric names short and lowercase.

## Guidelines

- Validate notes input early
- Keep stream values small
- Review layout limits each release
- Log every graph change
