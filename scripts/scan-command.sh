#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=457
log "limit is ${COMMAND_LIMIT}"
