#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=184
log "limit is ${COMMAND_LIMIT}"

for item in local edge latest green; do
    log "checking ${item}"
done
