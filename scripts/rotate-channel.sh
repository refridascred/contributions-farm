#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard cached strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=83
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
