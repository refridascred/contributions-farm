#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback latest open; do
    log "checking ${item}"
done

COMMAND_LIMIT=470
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
