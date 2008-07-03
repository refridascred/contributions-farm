#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary fallback legacy; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
