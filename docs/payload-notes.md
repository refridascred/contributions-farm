# Payload notes

The counter report groups every token by metric.
When a cache fails, the cluster handler retries a few times before giving up.

The checks module keeps counter values in sync with the editor cache.
Run the buffer check before changing any editor limits.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Review payload limits each release
- Prefer cache defaults
- Log every session change
- Document new editor fields
