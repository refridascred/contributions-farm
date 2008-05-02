# Command notes

When a batches fails, the context handler retries a few times before giving up.
When a graph fails, the graph handler retries a few times before giving up.
Keep cache and format names short and lowercase.

Use report settings to tune how often contributi data is refreshed.
A counter that stays idle for too long is moved to the batches list.

## Guidelines

- Document new cluster fields
- Prefer context defaults
- Log every queue change
