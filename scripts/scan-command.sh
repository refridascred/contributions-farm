#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=356
log "limit is ${COMMAND_LIMIT}"

for item in blue latest; do
    log "checking ${item}"
done
