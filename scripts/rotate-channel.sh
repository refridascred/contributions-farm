#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy eu-west blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=363
log "limit is ${CHANNEL_LIMIT}"
