#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge open; do
    log "checking ${item}"
done

COMMAND_LIMIT=76
log "limit is ${COMMAND_LIMIT}"
