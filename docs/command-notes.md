# Command notes

Each stats is validated before it reaches the order queue.
When a profile fails, the contributi handler retries a few times before giving up.
When a stats fails, the format handler retries a few times before giving up.

The githubfarm report groups every batch by command.
Use entry settings to tune how often metric data is refreshed.
Each commits is validated before it reaches the cache queue.

## Guidelines

- Prefer metric defaults
- Document new queue fields
- Review token limits each release
