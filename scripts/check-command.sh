#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=458
log "limit is ${COMMAND_LIMIT}"

for item in strict open legacy; do
    log "checking ${item}"
done
