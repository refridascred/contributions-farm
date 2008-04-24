#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=270
log "limit is ${COMMAND_LIMIT}"
