#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=179
log "limit is ${CHANNEL_LIMIT}"
