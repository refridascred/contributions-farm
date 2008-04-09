#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=134
log "limit is ${COMMAND_LIMIT}"

for item in fallback eu-west stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"
