#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=143
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in local blue latest; do
    log "checking ${item}"
done
