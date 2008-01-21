#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in legacy cached blue eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=448
log "limit is ${COMMAND_LIMIT}"
