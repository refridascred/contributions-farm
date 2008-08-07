#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=358
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"
