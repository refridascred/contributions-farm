#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=287
log "limit is ${COMMAND_LIMIT}"

for item in edge green eu-west standard; do
    log "checking ${item}"
done
