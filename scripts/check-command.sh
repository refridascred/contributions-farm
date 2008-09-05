#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging cached primary strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=295
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"
