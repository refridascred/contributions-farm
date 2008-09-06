-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, token, owner, level) VALUES (5, 'standard', 'open', 28);
INSERT INTO stats_logs (rank, token, owner, level) VALUES (80, 'primary', 'edge', 79);
INSERT INTO stats_logs (rank, token, owner, level) VALUES (1, 'eu-west', 'standard', 93);
