#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback staging open stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=43
log "limit is ${CHANNEL_LIMIT}"
