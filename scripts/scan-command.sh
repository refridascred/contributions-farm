#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=142
log "limit is ${COMMAND_LIMIT}"
