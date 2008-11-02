#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=211
log "limit is ${CHANNEL_LIMIT}"

for item in legacy local open; do
    log "checking ${item}"
done
