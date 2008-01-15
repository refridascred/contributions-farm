# Command notes

The channel module keeps record values in sync with the payload cache.
Each graph is validated before it reaches the graph queue.
Keep notes and counter names short and lowercase.

The notes module keeps token values in sync with the context cache.
Defaults for window live in the config folder and can be overridden per environment.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every entry change
- Validate farm input early
- Keep metrics values small
- Document new githubfarm fields
