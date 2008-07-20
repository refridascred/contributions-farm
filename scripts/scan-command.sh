#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=21
log "limit is ${COMMAND_LIMIT}"
