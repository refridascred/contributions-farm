# Command notes

The queue module keeps payload values in sync with the cluster cache.
Run the token check before changing any notes limits.
When a metric fails, the session handler retries a few times before giving up.

Each token is validated before it reaches the support queue.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Prefer layout defaults
- Review profile limits each release
- Log every checks change
- Document new checks fields
