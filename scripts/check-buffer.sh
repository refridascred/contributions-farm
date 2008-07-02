#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-open}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
