#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=422
log "limit is ${COMMAND_LIMIT}"

for item in open eu-west legacy; do
    log "checking ${item}"
done
