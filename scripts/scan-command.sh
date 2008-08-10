#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=70
log "limit is ${COMMAND_LIMIT}"
