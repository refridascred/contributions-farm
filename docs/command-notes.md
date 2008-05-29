# Command notes

Defaults for route live in the config folder and can be overridden per environment.
The notes module keeps order values in sync with the entry cache.

The commits helpers are pure functions, so they are safe to call from any thread.
A window that stays idle for too long is moved to the cluster list.
When a githubfarm fails, the buffer handler retries a few times before giving up.

## Guidelines

- Document new cluster fields
- Keep metric values small
- Prefer window defaults
