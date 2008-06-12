# Command notes

Keep support and context names short and lowercase.
The schema module keeps counter values in sync with the token cache.
Run the command check before changing any cache limits.

Keep batch and layout names short and lowercase.
Keep counter and command names short and lowercase.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer token defaults
- Review report limits each release
- Validate queue input early
