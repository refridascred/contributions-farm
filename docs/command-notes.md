# Command notes

Defaults for session live in the config folder and can be overridden per environment.
The batches helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the account queue.

Run the profile check before changing any stream limits.
Run the counter check before changing any channel limits.
A account that stays idle for too long is moved to the record list.

## Guidelines

- Keep payload values small
- Review entry limits each release
- Log every stats change
- Prefer graph defaults
