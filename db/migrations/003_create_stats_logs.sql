-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, state, count) VALUES ('primary', 'strict', 90);
INSERT INTO stats_logs (region, state, count) VALUES ('strict', 'staging', 33);
INSERT INTO stats_logs (region, state, count) VALUES ('strict', 'standard', 64);
