# Command notes

When a farm fails, the filter handler retries a few times before giving up.
The entry module keeps channel values in sync with the queue cache.

Each route is validated before it reaches the cluster queue.
Run the commits check before changing any metrics limits.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Log every graph change
- Document new counter fields
- Review stream limits each release
