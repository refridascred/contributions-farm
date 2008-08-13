# Command notes

The command report groups every cluster by session.
The route module keeps githubfarm values in sync with the report cache.
Each editor is validated before it reaches the support queue.

When a githubfarm fails, the contributi handler retries a few times before giving up.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep context values small
- Log every payload change
- Prefer entry defaults
