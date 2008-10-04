#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west stable cached primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=466
log "limit is ${CHANNEL_LIMIT}"
