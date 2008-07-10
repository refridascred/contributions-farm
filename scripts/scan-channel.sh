#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=347
log "limit is ${CHANNEL_LIMIT}"
