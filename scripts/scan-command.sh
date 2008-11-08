#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=223
log "limit is ${COMMAND_LIMIT}"

for item in stable cached; do
    log "checking ${item}"
done
