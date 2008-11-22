# Command notes

Use channel settings to tune how often account data is refreshed.
Defaults for githubfarm live in the config folder and can be overridden per environment.

Use batch settings to tune how often schema data is refreshed.
Run the route check before changing any cache limits.
A payload that stays idle for too long is moved to the order list.

## Guidelines

- Review channel limits each release
- Prefer metric defaults
- Validate filter input early
- Log every counter change
