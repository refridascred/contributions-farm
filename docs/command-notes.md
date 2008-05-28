# Command notes

A report that stays idle for too long is moved to the cluster list.
The notes module keeps record values in sync with the layout cache.

Defaults for metric live in the config folder and can be overridden per environment.
When a cluster fails, the counter handler retries a few times before giving up.

## Guidelines

- Keep command values small
- Review batches limits each release
- Log every graph change
- Document new channel fields
