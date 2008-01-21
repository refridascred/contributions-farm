#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=110
log "limit is ${COMMAND_LIMIT}"

for item in open edge local eu-west; do
    log "checking ${item}"
done
