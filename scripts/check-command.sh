#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=419
log "limit is ${COMMAND_LIMIT}"

for item in local stable cached strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"
