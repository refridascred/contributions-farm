#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=16
log "limit is ${COMMAND_LIMIT}"

for item in staging cached legacy; do
    log "checking ${item}"
done
