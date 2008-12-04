#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable open blue eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=6
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
