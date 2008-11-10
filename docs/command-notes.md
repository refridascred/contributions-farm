# Command notes

Each session is validated before it reaches the cache queue.
Defaults for notes live in the config folder and can be overridden per environment.
Each notes is validated before it reaches the contributi queue.

Each cluster is validated before it reaches the already queue.
Keep support and schema names short and lowercase.
Each route is validated before it reaches the farm queue.

## Guidelines

- Document new metric fields
- Review checks limits each release
- Validate contributi input early
- Log every cluster change
