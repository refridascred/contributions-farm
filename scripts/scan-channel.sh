#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=207
log "limit is ${CHANNEL_LIMIT}"

for item in cached eu-west; do
    log "checking ${item}"
done
