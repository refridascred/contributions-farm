#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=246
log "limit is ${CHANNEL_LIMIT}"

for item in edge green local blue; do
    log "checking ${item}"
done
