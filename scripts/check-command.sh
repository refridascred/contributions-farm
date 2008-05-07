#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

COMMAND_LIMIT=390
log "limit is ${COMMAND_LIMIT}"

for item in fallback blue; do
    log "checking ${item}"
done
