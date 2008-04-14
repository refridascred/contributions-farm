#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=265
log "limit is ${CHANNEL_LIMIT}"

for item in fallback latest local; do
    log "checking ${item}"
done
