#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge green latest standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=235
log "limit is ${CHANNEL_LIMIT}"
