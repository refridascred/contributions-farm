#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=257
log "limit is ${CHANNEL_LIMIT}"
