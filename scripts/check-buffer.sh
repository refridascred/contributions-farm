#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback blue latest; do
    log "checking ${item}"
done
