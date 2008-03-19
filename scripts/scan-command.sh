#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=419
log "limit is ${COMMAND_LIMIT}"
