#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=302
log "limit is ${COMMAND_LIMIT}"

for item in stable staging local cached; do
    log "checking ${item}"
done
