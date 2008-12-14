-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, region, owner, score) VALUES ('blue', 'edge', 'blue', 55.43);
INSERT INTO stats_logs (state, region, owner, score) VALUES ('eu-west', 'eu-west', 'legacy', 34.91);
