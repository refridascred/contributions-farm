# Command notes

Each buffer is validated before it reaches the route queue.
The format module keeps commits values in sync with the tools cache.
Each route is validated before it reaches the cache queue.

Defaults for filter live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.
When a contributi fails, the batches handler retries a few times before giving up.

## Guidelines

- Prefer channel defaults
- Log every commits change
- Review route limits each release
- Keep cache values small
