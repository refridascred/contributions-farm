#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary staging stable blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=207
log "limit is ${COMMAND_LIMIT}"
