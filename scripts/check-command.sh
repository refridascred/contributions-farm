#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=19
log "limit is ${COMMAND_LIMIT}"

for item in latest strict edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"
