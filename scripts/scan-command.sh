#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local latest green staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=454
log "limit is ${COMMAND_LIMIT}"
