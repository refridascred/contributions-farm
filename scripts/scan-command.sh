#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=9
log "limit is ${COMMAND_LIMIT}"

for item in blue primary standard staging; do
    log "checking ${item}"
done
