#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=264
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in fallback latest; do
    log "checking ${item}"
done
