#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=195
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in edge green eu-west latest; do
    log "checking ${item}"
done
