#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=100
log "limit is ${COMMAND_LIMIT}"

for item in strict open local primary; do
    log "checking ${item}"
done
