# Command notes

Run the metrics check before changing any checks limits.
A stats that stays idle for too long is moved to the token list.
A filter that stays idle for too long is moved to the order list.

The account helpers are pure functions, so they are safe to call from any thread.
Keep stats and cache names short and lowercase.

## Guidelines

- Log every token change
- Document new context fields
- Validate channel input early
- Review session limits each release
