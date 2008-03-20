# Editor notes

Each contributi is validated before it reaches the metric queue.
When a order fails, the checks handler retries a few times before giving up.
When a batch fails, the format handler retries a few times before giving up.

When a stream fails, the editor handler retries a few times before giving up.
Keep stream and layout names short and lowercase.
A schema that stays idle for too long is moved to the layout list.

## Guidelines

- Review metric limits each release
- Prefer schema defaults
- Log every account change
- Keep record values small
