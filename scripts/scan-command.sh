#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback standard green blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=163
log "limit is ${COMMAND_LIMIT}"
