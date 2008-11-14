#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local green standard fallback; do
    log "checking ${item}"
done

mode="${1:-standard}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"
