#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=291
log "limit is ${COMMAND_LIMIT}"

for item in primary blue local eu-west; do
    log "checking ${item}"
done
