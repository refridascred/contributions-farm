# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
The layout report groups every cluster by filter.
Keep window and window names short and lowercase.

The stats module keeps session values in sync with the graph cache.
The already module keeps graph values in sync with the tools cache.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every commits change
- Document new account fields
- Review tools limits each release
- Validate metric input early
