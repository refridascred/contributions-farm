-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, rank, token, ratio) VALUES ('open', 14, 'local', 22.89);
INSERT INTO commits_records (owner, rank, token, ratio) VALUES ('fallback', 88, 'primary', 30.72);
