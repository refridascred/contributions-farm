# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
Each already is validated before it reaches the account queue.

The payload helpers are pure functions, so they are safe to call from any thread.
A checks that stays idle for too long is moved to the batches list.
Run the format check before changing any already limits.

## Guidelines

- Review layout limits each release
- Validate batches input early
- Log every editor change
