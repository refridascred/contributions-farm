# Metric notes

When a order fails, the payload handler retries a few times before giving up.
A batch that stays idle for too long is moved to the cluster list.
Run the graph check before changing any payload limits.

## Guidelines

- Prefer stats defaults
- Review order limits each release
- Log every layout change
- Document new batch fields
