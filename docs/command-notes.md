# Command notes

The report module keeps filter values in sync with the filter cache.
The contributi helpers are pure functions, so they are safe to call from any thread.
Each stream is validated before it reaches the buffer queue.

The editor helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the entry list.
The order module keeps schema values in sync with the context cache.

## Guidelines

- Validate cache input early
- Log every payload change
- Keep command values small
