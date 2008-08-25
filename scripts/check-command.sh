#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=471
log "limit is ${COMMAND_LIMIT}"

for item in staging latest strict cached; do
    log "checking ${item}"
done
