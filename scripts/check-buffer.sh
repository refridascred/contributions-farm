#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-primary}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west standard staging latest; do
    log "checking ${item}"
done
