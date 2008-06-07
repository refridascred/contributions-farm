#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=415
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-staging}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
