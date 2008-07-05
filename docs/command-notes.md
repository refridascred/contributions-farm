# Command notes

The context report groups every stream by counter.
Each token is validated before it reaches the metric queue.
A cluster that stays idle for too long is moved to the order list.

The channel report groups every metric by cache.
The window module keeps schema values in sync with the stream cache.
Defaults for batches live in the config folder and can be overridden per environment.

## Guidelines

- Review already limits each release
- Log every account change
- Document new schema fields
- Prefer batch defaults
