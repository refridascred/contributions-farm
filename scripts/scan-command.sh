#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy edge primary latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=106
log "limit is ${COMMAND_LIMIT}"
