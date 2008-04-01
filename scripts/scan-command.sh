#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge blue legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=8
log "limit is ${COMMAND_LIMIT}"
