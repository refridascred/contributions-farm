#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"
