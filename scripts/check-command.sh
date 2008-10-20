#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=384
log "limit is ${COMMAND_LIMIT}"

for item in cached staging strict latest; do
    log "checking ${item}"
done
