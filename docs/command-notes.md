# Command notes

Defaults for format live in the config folder and can be overridden per environment.
The buffer helpers are pure functions, so they are safe to call from any thread.
The cache report groups every metric by buffer.

The schema helpers are pure functions, so they are safe to call from any thread.
Run the cluster check before changing any stats limits.

## Guidelines

- Log every commits change
- Review support limits each release
- Validate githubfarm input early
- Document new stream fields
