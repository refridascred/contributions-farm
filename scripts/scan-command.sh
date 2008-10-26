#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=186
log "limit is ${COMMAND_LIMIT}"
