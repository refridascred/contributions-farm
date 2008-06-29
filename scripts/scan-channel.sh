#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=147
log "limit is ${CHANNEL_LIMIT}"

for item in fallback stable legacy blue; do
    log "checking ${item}"
done
