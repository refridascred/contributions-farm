#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west latest standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"

COMMAND_LIMIT=379
log "limit is ${COMMAND_LIMIT}"
