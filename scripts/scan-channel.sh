#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-legacy}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
