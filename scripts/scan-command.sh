#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open standard green edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=53
log "limit is ${COMMAND_LIMIT}"
