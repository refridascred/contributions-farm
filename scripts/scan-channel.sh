#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=474
log "limit is ${CHANNEL_LIMIT}"

for item in local cached; do
    log "checking ${item}"
done
