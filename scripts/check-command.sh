#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=353
log "limit is ${COMMAND_LIMIT}"

for item in fallback local cached blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"
