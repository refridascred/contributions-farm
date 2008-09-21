#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=196
log "limit is ${COMMAND_LIMIT}"

for item in latest local fallback strict; do
    log "checking ${item}"
done
