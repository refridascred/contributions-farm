#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback staging local legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=32
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
