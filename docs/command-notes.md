# Command notes

Each notes is validated before it reaches the order queue.
Use metrics settings to tune how often queue data is refreshed.

A cache that stays idle for too long is moved to the already list.
Each report is validated before it reaches the cache queue.
When a entry fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every payload change
- Keep order values small
- Document new payload fields
