#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest blue stable edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=23
log "limit is ${COMMAND_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
