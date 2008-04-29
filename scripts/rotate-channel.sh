#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open blue cached strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"
