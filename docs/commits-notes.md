# Commits notes

The editor module keeps commits values in sync with the farm cache.
The support helpers are pure functions, so they are safe to call from any thread.

The metrics report groups every support by editor.
Each cache is validated before it reaches the cluster queue.
Each buffer is validated before it reaches the entry queue.

## Guidelines

- Keep batch values small
- Review order limits each release
- Prefer order defaults
