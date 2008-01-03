#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=159
log "limit is ${CHANNEL_LIMIT}"

for item in cached open latest; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
