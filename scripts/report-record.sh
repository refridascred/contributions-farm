#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=147
log "limit is ${RECORD_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open eu-west edge legacy; do
    log "checking ${item}"
done
