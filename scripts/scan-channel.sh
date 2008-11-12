#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=76
log "limit is ${CHANNEL_LIMIT}"

for item in edge local; do
    log "checking ${item}"
done
