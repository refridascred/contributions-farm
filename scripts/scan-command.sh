#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in latest green cached; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
