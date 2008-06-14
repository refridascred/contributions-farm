#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=498
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"
