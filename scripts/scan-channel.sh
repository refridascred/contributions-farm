#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=294
log "limit is ${CHANNEL_LIMIT}"

for item in cached open green strict; do
    log "checking ${item}"
done
