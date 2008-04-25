#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=301
log "limit is ${CHANNEL_LIMIT}"

for item in legacy eu-west standard fallback; do
    log "checking ${item}"
done
