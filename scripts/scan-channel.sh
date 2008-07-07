#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=285
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west fallback; do
    log "checking ${item}"
done
