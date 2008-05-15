#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=453
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached edge fallback; do
    log "checking ${item}"
done
