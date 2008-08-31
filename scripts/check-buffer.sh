#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging green local latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-primary}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
