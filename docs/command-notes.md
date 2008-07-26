# Command notes

A graph that stays idle for too long is moved to the cluster list.
Each buffer is validated before it reaches the record queue.
The githubfarm report groups every counter by record.

Use record settings to tune how often session data is refreshed.
Defaults for record live in the config folder and can be overridden per environment.
The filter module keeps already values in sync with the context cache.

## Guidelines

- Log every cache change
- Document new session fields
- Review payload limits each release
- Validate counter input early
