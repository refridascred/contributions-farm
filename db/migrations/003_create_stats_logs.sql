-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, rank) VALUES ('legacy', 'fallback', 23);
INSERT INTO stats_logs (owner, token, rank) VALUES ('eu-west', 'staging', 24);
INSERT INTO stats_logs (owner, token, rank) VALUES ('stable', 'strict', 62);
