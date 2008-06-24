#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary stable edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=73
log "limit is ${COMMAND_LIMIT}"
