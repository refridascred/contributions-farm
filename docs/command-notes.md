# Command notes

Run the graph check before changing any command limits.
Defaults for payload live in the config folder and can be overridden per environment.
The profile module keeps cluster values in sync with the schema cache.

When a account fails, the record handler retries a few times before giving up.
Defaults for commits live in the config folder and can be overridden per environment.
When a schema fails, the filter handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Document new window fields
- Log every githubfarm change
