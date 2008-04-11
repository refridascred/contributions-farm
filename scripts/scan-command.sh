#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=209
log "limit is ${COMMAND_LIMIT}"
