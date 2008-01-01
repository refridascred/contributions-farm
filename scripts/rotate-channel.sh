#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=266
log "limit is ${CHANNEL_LIMIT}"

for item in strict eu-west; do
    log "checking ${item}"
done
