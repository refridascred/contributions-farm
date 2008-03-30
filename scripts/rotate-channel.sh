#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=130
log "limit is ${CHANNEL_LIMIT}"

for item in local fallback cached; do
    log "checking ${item}"
done
