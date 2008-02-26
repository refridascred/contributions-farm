#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue standard open; do
    log "checking ${item}"
done

COMMAND_LIMIT=411
log "limit is ${COMMAND_LIMIT}"
