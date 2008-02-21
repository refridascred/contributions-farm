#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict latest open staging; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"
