#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=12
log "limit is ${CHANNEL_LIMIT}"

for item in standard latest local primary; do
    log "checking ${item}"
done
