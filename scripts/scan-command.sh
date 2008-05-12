#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=396
log "limit is ${COMMAND_LIMIT}"

for item in open staging; do
    log "checking ${item}"
done
