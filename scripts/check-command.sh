#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=73
log "limit is ${COMMAND_LIMIT}"
