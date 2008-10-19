#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=67
log "limit is ${CHANNEL_LIMIT}"

for item in fallback stable latest eu-west; do
    log "checking ${item}"
done
