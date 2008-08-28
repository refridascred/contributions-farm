-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, token, region, score) VALUES (5, 'staging', 'edge', 86.35);
INSERT INTO commits_records (rank, token, region, score) VALUES (63, 'stable', 'stable', 0.68);
INSERT INTO commits_records (rank, token, region, score) VALUES (68, 'local', 'local', 80.35);
