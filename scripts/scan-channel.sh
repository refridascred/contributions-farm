#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging primary blue standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=191
log "limit is ${CHANNEL_LIMIT}"
