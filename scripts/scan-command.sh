#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=388
log "limit is ${COMMAND_LIMIT}"

for item in edge eu-west standard; do
    log "checking ${item}"
done
