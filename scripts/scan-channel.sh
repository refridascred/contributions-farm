#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=52
log "limit is ${CHANNEL_LIMIT}"

for item in edge legacy; do
    log "checking ${item}"
done
