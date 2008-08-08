#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green standard local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"
