#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging standard latest primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=411
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
