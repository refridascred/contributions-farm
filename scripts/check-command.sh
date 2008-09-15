#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"

COMMAND_LIMIT=412
log "limit is ${COMMAND_LIMIT}"

for item in green primary edge; do
    log "checking ${item}"
done
