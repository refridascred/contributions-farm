#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in fallback standard strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=149
log "limit is ${COMMAND_LIMIT}"
