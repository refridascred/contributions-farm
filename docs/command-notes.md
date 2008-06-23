# Command notes

Use already settings to tune how often checks data is refreshed.
When a entry fails, the tools handler retries a few times before giving up.

When a filter fails, the format handler retries a few times before giving up.
Each batch is validated before it reaches the farm queue.

## Guidelines

- Prefer notes defaults
- Document new metrics fields
- Log every layout change
- Validate profile input early
