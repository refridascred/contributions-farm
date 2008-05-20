#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green blue standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=421
log "limit is ${CHANNEL_LIMIT}"
