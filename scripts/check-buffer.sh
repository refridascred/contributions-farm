#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"
