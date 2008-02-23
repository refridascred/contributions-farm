#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
