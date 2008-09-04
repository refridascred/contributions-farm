#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local edge stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"
