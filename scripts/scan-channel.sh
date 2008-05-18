#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=289
log "limit is ${CHANNEL_LIMIT}"

for item in staging fallback local blue; do
    log "checking ${item}"
done
