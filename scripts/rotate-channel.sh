#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached latest edge local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=23
log "limit is ${CHANNEL_LIMIT}"
