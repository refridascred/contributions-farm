-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, state, score) VALUES ('stable', 'cached', 18.13);
INSERT INTO stats_logs (region, state, score) VALUES ('eu-west', 'local', 59.39);
INSERT INTO stats_logs (region, state, score) VALUES ('strict', 'stable', 73.52);
