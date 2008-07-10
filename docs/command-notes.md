# Command notes

The buffer module keeps context values in sync with the batches cache.
The stats module keeps filter values in sync with the queue cache.
The order report groups every buffer by already.

The record report groups every stream by buffer.
Defaults for route live in the config folder and can be overridden per environment.
A token that stays idle for too long is moved to the checks list.

## Guidelines

- Prefer cache defaults
- Review contributi limits each release
- Document new githubfarm fields
- Validate report input early
