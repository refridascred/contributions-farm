# Command notes

A profile that stays idle for too long is moved to the cluster list.
The already module keeps profile values in sync with the command cache.
Run the metrics check before changing any queue limits.

Run the filter check before changing any stats limits.
Use counter settings to tune how often queue data is refreshed.

## Guidelines

- Review counter limits each release
- Keep graph values small
- Document new layout fields
- Validate commits input early
