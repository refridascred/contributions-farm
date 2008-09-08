#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback stable local; do
    log "checking ${item}"
done

COMMAND_LIMIT=54
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"
