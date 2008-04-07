#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=185
log "limit is ${COMMAND_LIMIT}"

for item in latest primary open stable; do
    log "checking ${item}"
done
