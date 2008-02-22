#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=394
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west strict; do
    log "checking ${item}"
done
