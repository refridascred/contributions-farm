#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard green; do
    log "checking ${item}"
done

COMMAND_LIMIT=81
log "limit is ${COMMAND_LIMIT}"
