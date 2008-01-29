#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"
