#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy strict open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"
