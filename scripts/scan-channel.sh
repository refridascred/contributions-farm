#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=332
log "limit is ${CHANNEL_LIMIT}"

for item in fallback strict local green; do
    log "checking ${item}"
done
