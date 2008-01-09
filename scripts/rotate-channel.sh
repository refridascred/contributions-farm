#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=335
log "limit is ${CHANNEL_LIMIT}"

for item in staging primary legacy; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
