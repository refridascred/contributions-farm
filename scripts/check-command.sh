#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=393
log "limit is ${COMMAND_LIMIT}"

for item in legacy latest; do
    log "checking ${item}"
done
