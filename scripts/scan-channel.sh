#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in stable open green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=142
log "limit is ${CHANNEL_LIMIT}"
