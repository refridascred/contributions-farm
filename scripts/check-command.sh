#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=382
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
