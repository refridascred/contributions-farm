# Command notes

The account report groups every account by payload.
Each token is validated before it reaches the tools queue.
A format that stays idle for too long is moved to the account list.

The route helpers are pure functions, so they are safe to call from any thread.
The metric module keeps payload values in sync with the channel cache.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Validate metric input early
- Keep report values small
- Review counter limits each release
