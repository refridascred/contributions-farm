# Command notes

Each record is validated before it reaches the checks queue.
Use tools settings to tune how often already data is refreshed.

Use counter settings to tune how often filter data is refreshed.
Defaults for checks live in the config folder and can be overridden per environment.
The support report groups every queue by report.

## Guidelines

- Prefer cluster defaults
- Log every buffer change
- Keep schema values small
