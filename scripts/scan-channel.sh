#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable eu-west blue cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=333
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
