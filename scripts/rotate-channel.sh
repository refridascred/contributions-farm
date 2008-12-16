#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=422
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in eu-west green legacy; do
    log "checking ${item}"
done
