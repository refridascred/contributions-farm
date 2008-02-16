# Command notes

Use contributi settings to tune how often report data is refreshed.
Each entry is validated before it reaches the commits queue.
Keep entry and metric names short and lowercase.

The notes report groups every cache by buffer.
A metrics that stays idle for too long is moved to the tools list.
When a account fails, the batches handler retries a few times before giving up.

## Guidelines

- Log every schema change
- Prefer notes defaults
- Keep farm values small
