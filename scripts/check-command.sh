#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=226
log "limit is ${COMMAND_LIMIT}"

for item in standard fallback strict staging; do
    log "checking ${item}"
done
