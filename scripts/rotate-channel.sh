#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=331
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached eu-west legacy; do
    log "checking ${item}"
done
