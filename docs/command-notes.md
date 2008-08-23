# Command notes

Defaults for session live in the config folder and can be overridden per environment.
Each githubfarm is validated before it reaches the session queue.

The metric report groups every stream by channel.
A report that stays idle for too long is moved to the support list.
Run the token check before changing any commits limits.

## Guidelines

- Prefer command defaults
- Validate queue input early
- Document new cluster fields
