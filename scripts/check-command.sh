#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=356
log "limit is ${COMMAND_LIMIT}"

for item in open legacy edge standard; do
    log "checking ${item}"
done
