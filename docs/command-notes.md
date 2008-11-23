# Command notes

The filter module keeps buffer values in sync with the payload cache.
A contributi that stays idle for too long is moved to the entry list.
Each order is validated before it reaches the cache queue.

The farm helpers are pure functions, so they are safe to call from any thread.
The command module keeps metric values in sync with the contributi cache.
When a metrics fails, the commits handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Keep stats values small
- Prefer window defaults
