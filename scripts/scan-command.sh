#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=424
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"
