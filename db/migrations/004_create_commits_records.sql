-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner, rank) VALUES (64.63, 'staging', 22);
INSERT INTO commits_records (ratio, owner, rank) VALUES (95.37, 'fallback', 96);
