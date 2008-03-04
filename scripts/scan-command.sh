#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=259
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"
