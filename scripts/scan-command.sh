#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local blue cached staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=340
log "limit is ${COMMAND_LIMIT}"
