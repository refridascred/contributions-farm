#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=370
log "limit is ${COMMAND_LIMIT}"
