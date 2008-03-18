#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in fallback edge eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=33
log "limit is ${COMMAND_LIMIT}"
