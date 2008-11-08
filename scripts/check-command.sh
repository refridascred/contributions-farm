#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=492
log "limit is ${COMMAND_LIMIT}"

for item in green cached legacy; do
    log "checking ${item}"
done
