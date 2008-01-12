#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=37
log "limit is ${CHANNEL_LIMIT}"
