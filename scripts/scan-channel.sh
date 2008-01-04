#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local blue staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=458
log "limit is ${CHANNEL_LIMIT}"
