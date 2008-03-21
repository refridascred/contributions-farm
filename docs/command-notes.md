# Command notes

A githubfarm that stays idle for too long is moved to the cluster list.
The batches module keeps window values in sync with the report cache.
Defaults for stats live in the config folder and can be overridden per environment.

Run the format check before changing any tools limits.
Run the commits check before changing any cache limits.
Use schema settings to tune how often tools data is refreshed.

## Guidelines

- Prefer stats defaults
- Keep batch values small
- Review command limits each release
- Validate context input early
