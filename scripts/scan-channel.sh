#!/usr/bin/env bash
# Scan the channel data.
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

for item in fallback local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
