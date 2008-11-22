#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=369
log "limit is ${COMMAND_LIMIT}"
