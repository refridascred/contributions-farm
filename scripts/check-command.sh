#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=467
log "limit is ${COMMAND_LIMIT}"

for item in latest eu-west; do
    log "checking ${item}"
done
