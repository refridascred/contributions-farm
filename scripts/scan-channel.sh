#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=135
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue open standard; do
    log "checking ${item}"
done
