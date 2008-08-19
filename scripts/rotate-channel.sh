#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest fallback local edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=288
log "limit is ${CHANNEL_LIMIT}"
