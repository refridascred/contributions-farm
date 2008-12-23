#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict primary latest blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"
