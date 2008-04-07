#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green local strict staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=368
log "limit is ${COMMAND_LIMIT}"
