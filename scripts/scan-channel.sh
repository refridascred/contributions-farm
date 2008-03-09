#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging green primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=469
log "limit is ${CHANNEL_LIMIT}"
