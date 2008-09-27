#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=199
log "limit is ${COMMAND_LIMIT}"

for item in local latest blue cached; do
    log "checking ${item}"
done
