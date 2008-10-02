#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=403
log "limit is ${CHANNEL_LIMIT}"

for item in edge local standard staging; do
    log "checking ${item}"
done
