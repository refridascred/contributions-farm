#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in staging standard local edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=335
log "limit is ${COMMAND_LIMIT}"
