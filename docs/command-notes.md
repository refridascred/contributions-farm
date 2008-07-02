# Command notes

The cluster module keeps batch values in sync with the metric cache.
Use notes settings to tune how often order data is refreshed.
When a cache fails, the command handler retries a few times before giving up.

Each notes is validated before it reaches the commits queue.
Keep cache and window names short and lowercase.

## Guidelines

- Document new report fields
- Log every layout change
- Prefer session defaults
- Keep schema values small
