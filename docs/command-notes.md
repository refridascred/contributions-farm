# Command notes

The route module keeps commits values in sync with the stream cache.
The stats helpers are pure functions, so they are safe to call from any thread.
Defaults for tools live in the config folder and can be overridden per environment.

A checks that stays idle for too long is moved to the entry list.
The stream module keeps route values in sync with the order cache.
Use githubfarm settings to tune how often graph data is refreshed.

## Guidelines

- Keep already values small
- Log every stream change
- Validate farm input early
