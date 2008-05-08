#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west local blue standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=78
log "limit is ${CHANNEL_LIMIT}"
