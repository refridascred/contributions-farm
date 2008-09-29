-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, token, level, ratio) VALUES (61, 'edge', 4, 17.51);
INSERT INTO commits_records (rank, token, level, ratio) VALUES (78, 'edge', 12, 59.73);
