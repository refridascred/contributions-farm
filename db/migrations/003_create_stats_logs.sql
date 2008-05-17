-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, region, rank, owner, level) VALUES ('blue', 'fallback', 0, 'strict', 19);
INSERT INTO stats_logs (state, region, rank, owner, level) VALUES ('latest', 'cached', 28, 'staging', 64);
