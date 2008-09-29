#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=393
log "limit is ${COMMAND_LIMIT}"

for item in cached strict stable standard; do
    log "checking ${item}"
done
