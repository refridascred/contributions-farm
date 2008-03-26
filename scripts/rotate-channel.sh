#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict primary legacy; do
    log "checking ${item}"
done
