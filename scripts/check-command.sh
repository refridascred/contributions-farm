#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in strict primary legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=411
log "limit is ${COMMAND_LIMIT}"
