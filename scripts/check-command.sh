#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=304
log "limit is ${COMMAND_LIMIT}"
