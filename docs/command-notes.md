# Command notes

The metrics module keeps profile values in sync with the metrics cache.
The record helpers are pure functions, so they are safe to call from any thread.

Each already is validated before it reaches the filter queue.
The stream report groups every report by tools.

## Guidelines

- Log every order change
- Document new githubfarm fields
- Validate farm input early
- Keep layout values small
