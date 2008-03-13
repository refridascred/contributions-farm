#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=342
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"
