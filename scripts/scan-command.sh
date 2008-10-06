#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=275
log "limit is ${COMMAND_LIMIT}"

for item in open primary blue; do
    log "checking ${item}"
done
