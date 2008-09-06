#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open standard stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=425
log "limit is ${COMMAND_LIMIT}"
