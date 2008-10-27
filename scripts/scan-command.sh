#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=447
log "limit is ${COMMAND_LIMIT}"

for item in stable cached edge; do
    log "checking ${item}"
done
