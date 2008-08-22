#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in fallback local primary latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=422
log "limit is ${COMMAND_LIMIT}"
