# Command notes

When a farm fails, the account handler retries a few times before giving up.
Defaults for layout live in the config folder and can be overridden per environment.
Run the stats check before changing any cache limits.

The format report groups every notes by route.
The queue module keeps payload values in sync with the route cache.
Keep order and metric names short and lowercase.

## Guidelines

- Prefer command defaults
- Validate payload input early
- Review command limits each release
