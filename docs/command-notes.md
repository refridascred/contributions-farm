# Command notes

The record module keeps stats values in sync with the support cache.
Keep cluster and account names short and lowercase.

The context module keeps session values in sync with the counter cache.
When a metrics fails, the queue handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Document new batch fields
- Review tools limits each release
