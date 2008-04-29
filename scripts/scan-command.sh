#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=407
log "limit is ${COMMAND_LIMIT}"
