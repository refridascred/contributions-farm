#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict fallback; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-green}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
