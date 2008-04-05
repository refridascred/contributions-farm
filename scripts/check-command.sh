#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in latest cached local staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=9
log "limit is ${COMMAND_LIMIT}"
