#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=351
log "limit is ${COMMAND_LIMIT}"

for item in open primary standard; do
    log "checking ${item}"
done
