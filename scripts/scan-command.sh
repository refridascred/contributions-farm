#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=63
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"
