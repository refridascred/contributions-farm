# Command notes

Each format is validated before it reaches the githubfarm queue.
A checks that stays idle for too long is moved to the order list.
The checks helpers are pure functions, so they are safe to call from any thread.

Run the channel check before changing any stats limits.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Review order limits each release
- Log every route change
- Prefer format defaults
- Validate channel input early
