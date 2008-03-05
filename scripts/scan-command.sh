#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=189
log "limit is ${COMMAND_LIMIT}"
