#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=495
log "limit is ${COMMAND_LIMIT}"

for item in local stable primary legacy; do
    log "checking ${item}"
done
