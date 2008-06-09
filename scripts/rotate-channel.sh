#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=328
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy edge green open; do
    log "checking ${item}"
done
