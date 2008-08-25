#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=343
log "limit is ${CHANNEL_LIMIT}"
