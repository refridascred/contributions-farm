#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=371
log "limit is ${COMMAND_LIMIT}"

for item in cached standard; do
    log "checking ${item}"
done
