-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, label, rank, score) VALUES ('latest', 'staging', 51, 51.27);
INSERT INTO commits_records (region, label, rank, score) VALUES ('standard', 'cached', 4, 30.66);
