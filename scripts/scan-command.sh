#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=489
log "limit is ${COMMAND_LIMIT}"

for item in cached local latest blue; do
    log "checking ${item}"
done
