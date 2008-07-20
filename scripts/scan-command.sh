#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-primary}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=391
log "limit is ${COMMAND_LIMIT}"
