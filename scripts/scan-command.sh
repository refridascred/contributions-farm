#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=46
log "limit is ${COMMAND_LIMIT}"
