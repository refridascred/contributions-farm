#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=479
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
