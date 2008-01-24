# Command notes

When a stream fails, the editor handler retries a few times before giving up.
Each layout is validated before it reaches the metric queue.
Each notes is validated before it reaches the commits queue.

Defaults for commits live in the config folder and can be overridden per environment.
A checks that stays idle for too long is moved to the report list.
A order that stays idle for too long is moved to the commits list.

## Guidelines

- Validate githubfarm input early
- Document new stream fields
- Log every metric change
