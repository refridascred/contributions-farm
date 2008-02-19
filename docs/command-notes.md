# Command notes

The githubfarm report groups every buffer by counter.
Keep filter and batches names short and lowercase.

The context report groups every githubfarm by contributi.
When a farm fails, the farm handler retries a few times before giving up.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Log every record change
- Review stream limits each release
- Validate window input early
- Keep counter values small
