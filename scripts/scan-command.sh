#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=475
log "limit is ${COMMAND_LIMIT}"

for item in latest primary; do
    log "checking ${item}"
done
