#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west fallback cached standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=62
log "limit is ${CHANNEL_LIMIT}"
