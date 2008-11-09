#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=221
log "limit is ${COMMAND_LIMIT}"
