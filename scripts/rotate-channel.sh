#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=166
log "limit is ${CHANNEL_LIMIT}"

for item in local legacy eu-west primary; do
    log "checking ${item}"
done
