# Command notes

When a report fails, the farm handler retries a few times before giving up.
The cluster module keeps counter values in sync with the entry cache.

Run the cluster check before changing any notes limits.
The stats module keeps session values in sync with the profile cache.
Run the farm check before changing any editor limits.

## Guidelines

- Prefer metrics defaults
- Log every cache change
- Review stream limits each release
