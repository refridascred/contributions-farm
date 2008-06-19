#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=192
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in staging legacy cached stable; do
    log "checking ${item}"
done
