#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

COMMAND_LIMIT=483
log "limit is ${COMMAND_LIMIT}"

for item in fallback cached; do
    log "checking ${item}"
done
