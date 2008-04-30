#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=409
log "limit is ${CHANNEL_LIMIT}"

for item in standard staging; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
