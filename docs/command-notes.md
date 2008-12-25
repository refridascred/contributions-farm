# Command notes

Each report is validated before it reaches the order queue.
A metric that stays idle for too long is moved to the schema list.

Use channel settings to tune how often farm data is refreshed.
Each record is validated before it reaches the record queue.
When a format fails, the session handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Document new githubfarm fields
- Review cluster limits each release
