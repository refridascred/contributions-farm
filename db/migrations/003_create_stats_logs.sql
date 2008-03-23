-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, region, rank, token, score) VALUES ('standard', 'staging', 28, 'standard', 98.2);
INSERT INTO stats_logs (state, region, rank, token, score) VALUES ('latest', 'strict', 65, 'eu-west', 14.72);
