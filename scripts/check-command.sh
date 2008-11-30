#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge strict latest green; do
    log "checking ${item}"
done

COMMAND_LIMIT=78
log "limit is ${COMMAND_LIMIT}"
