#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local primary latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=56
log "limit is ${COMMAND_LIMIT}"
