#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict standard cached green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
