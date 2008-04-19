#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback blue primary latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

COMMAND_LIMIT=59
log "limit is ${COMMAND_LIMIT}"
