#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback stable standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=246
log "limit is ${CHANNEL_LIMIT}"
