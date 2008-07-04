#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-staging}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
