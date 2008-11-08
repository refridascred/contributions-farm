# Editor notes

Run the support check before changing any editor limits.
When a cluster fails, the session handler retries a few times before giving up.

Run the payload check before changing any profile limits.
Run the graph check before changing any cluster limits.
The payload module keeps support values in sync with the order cache.

## Guidelines

- Keep session values small
- Validate already input early
- Document new metric fields
