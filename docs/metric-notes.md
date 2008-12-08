# Metric notes

Defaults for metric live in the config folder and can be overridden per environment.
When a record fails, the token handler retries a few times before giving up.
A metric that stays idle for too long is moved to the record list.

When a record fails, the counter handler retries a few times before giving up.
Keep githubfarm and buffer names short and lowercase.

## Guidelines

- Keep report values small
- Review route limits each release
- Document new support fields
