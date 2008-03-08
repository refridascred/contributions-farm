# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
The cluster module keeps payload values in sync with the already cache.
The notes helpers are pure functions, so they are safe to call from any thread.

The format report groups every window by session.
The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Validate order input early
- Review filter limits each release
- Log every notes change
