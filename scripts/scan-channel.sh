#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=151
log "limit is ${CHANNEL_LIMIT}"

for item in primary blue legacy; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
