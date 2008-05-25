#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=275
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"
