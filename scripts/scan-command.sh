#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict primary edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=120
log "limit is ${COMMAND_LIMIT}"
