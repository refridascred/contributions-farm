#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=499
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable fallback edge primary; do
    log "checking ${item}"
done
