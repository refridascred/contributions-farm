-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, token, owner, ratio) VALUES (89, 'legacy', 'primary', 95.31);
INSERT INTO commits_records (rank, token, owner, ratio) VALUES (65, 'legacy', 'cached', 62.53);
