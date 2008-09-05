#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open primary latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=153
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"
