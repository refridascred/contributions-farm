#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=65
log "limit is ${CHANNEL_LIMIT}"

for item in stable eu-west open; do
    log "checking ${item}"
done
