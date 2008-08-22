#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=85
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west legacy edge standard; do
    log "checking ${item}"
done
