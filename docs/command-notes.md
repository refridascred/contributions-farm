# Command notes

Each token is validated before it reaches the payload queue.
A schema that stays idle for too long is moved to the buffer list.
Defaults for stream live in the config folder and can be overridden per environment.

The session report groups every githubfarm by stream.
The schema module keeps queue values in sync with the graph cache.

## Guidelines

- Document new record fields
- Validate record input early
- Review checks limits each release
- Log every record change
