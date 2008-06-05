#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge fallback strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=444
log "limit is ${COMMAND_LIMIT}"
