#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary cached standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=38
log "limit is ${COMMAND_LIMIT}"
