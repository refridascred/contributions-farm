#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=45
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in open eu-west local legacy; do
    log "checking ${item}"
done
