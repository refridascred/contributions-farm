#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=467
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in primary cached eu-west; do
    log "checking ${item}"
done
