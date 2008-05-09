#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in eu-west stable legacy cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=408
log "limit is ${COMMAND_LIMIT}"
