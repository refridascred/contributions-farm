#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=303
log "limit is ${COMMAND_LIMIT}"

for item in latest cached blue; do
    log "checking ${item}"
done
