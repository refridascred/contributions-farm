#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=235
log "limit is ${CHANNEL_LIMIT}"

for item in local green primary staging; do
    log "checking ${item}"
done
