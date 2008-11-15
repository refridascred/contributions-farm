# Command notes

Each buffer is validated before it reaches the cluster queue.
When a report fails, the record handler retries a few times before giving up.

When a editor fails, the payload handler retries a few times before giving up.
Keep editor and queue names short and lowercase.
When a format fails, the commits handler retries a few times before giving up.

## Guidelines

- Review entry limits each release
- Log every githubfarm change
- Validate counter input early
- Prefer window defaults
