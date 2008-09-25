# Command notes

The checks report groups every route by batches.
Keep queue and schema names short and lowercase.

The buffer helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any batches limits.
Run the counter check before changing any filter limits.

## Guidelines

- Prefer route defaults
- Document new account fields
- Review context limits each release
- Keep token values small
