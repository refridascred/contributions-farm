-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, active, region, count) VALUES (74, 28, 'eu-west', 63);
INSERT INTO commits_records (rank, active, region, count) VALUES (86, 3, 'eu-west', 86);
INSERT INTO commits_records (rank, active, region, count) VALUES (95, 1, 'fallback', 57);
