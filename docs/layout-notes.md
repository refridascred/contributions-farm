# Layout notes

The booking module keeps tools values in sync with the report cache.
The window report groups every already by cluster.
The commits report groups every githubfarm by already.

The editor report groups every record by support.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate account input early
- Document new account fields
- Log every githubfarm change
- Keep tools values small
