# Command notes

The entry report groups every payload by metric.
A layout that stays idle for too long is moved to the record list.

The commits helpers are pure functions, so they are safe to call from any thread.
The batch report groups every order by commits.
The cluster module keeps buffer values in sync with the context cache.

## Guidelines

- Prefer githubfarm defaults
- Validate session input early
- Review session limits each release
- Log every cluster change
