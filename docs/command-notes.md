# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The contributi module keeps contributi values in sync with the layout cache.

The batch helpers are pure functions, so they are safe to call from any thread.
The metric report groups every route by order.

## Guidelines

- Prefer command defaults
- Validate editor input early
- Document new payload fields
- Log every editor change
