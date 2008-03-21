# Command notes

A report that stays idle for too long is moved to the stats list.
Each payload is validated before it reaches the cache queue.
A layout that stays idle for too long is moved to the cluster list.

Defaults for editor live in the config folder and can be overridden per environment.
Each editor is validated before it reaches the support queue.
The notes module keeps counter values in sync with the already cache.

## Guidelines

- Keep account values small
- Review token limits each release
- Validate editor input early
