# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Keep cluster and support names short and lowercase.

The payload module keeps already values in sync with the payload cache.
The stream module keeps support values in sync with the graph cache.

## Guidelines

- Prefer payload defaults
- Validate editor input early
- Log every buffer change
- Keep order values small
