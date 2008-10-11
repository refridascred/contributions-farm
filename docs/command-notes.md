# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The metric module keeps stats values in sync with the cluster cache.
Run the cache check before changing any report limits.

The entry report groups every account by cache.
Each metric is validated before it reaches the editor queue.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Document new graph fields
- Log every route change
- Review metrics limits each release
