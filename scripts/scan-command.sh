#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local stable staging green; do
    log "checking ${item}"
done

COMMAND_LIMIT=481
log "limit is ${COMMAND_LIMIT}"
