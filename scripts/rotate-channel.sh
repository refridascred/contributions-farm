#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=143
log "limit is ${CHANNEL_LIMIT}"

for item in legacy stable; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
