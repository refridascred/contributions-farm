#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue local latest open; do
    log "checking ${item}"
done

COMMAND_LIMIT=269
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"
