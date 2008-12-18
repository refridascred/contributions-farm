#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=91
log "limit is ${CHANNEL_LIMIT}"
