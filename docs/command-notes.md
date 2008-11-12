# Command notes

Each metric is validated before it reaches the support queue.
Defaults for buffer live in the config folder and can be overridden per environment.
Run the already check before changing any stats limits.

Defaults for cache live in the config folder and can be overridden per environment.
A graph that stays idle for too long is moved to the support list.
The format module keeps farm values in sync with the token cache.

## Guidelines

- Review profile limits each release
- Log every support change
- Validate filter input early
