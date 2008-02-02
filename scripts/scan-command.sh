#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in fallback strict eu-west local; do
    log "checking ${item}"
done

COMMAND_LIMIT=500
log "limit is ${COMMAND_LIMIT}"
