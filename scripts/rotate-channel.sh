#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=184
log "limit is ${CHANNEL_LIMIT}"

for item in cached legacy; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
