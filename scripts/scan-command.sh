#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open fallback edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-edge}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
