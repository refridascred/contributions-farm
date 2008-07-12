#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in fallback standard; do
    log "checking ${item}"
done

mode="${1:-standard}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
