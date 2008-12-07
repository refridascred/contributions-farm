-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, score) VALUES ('fallback', 59.29);
INSERT INTO commits_records (region, score) VALUES ('green', 78.38);
INSERT INTO commits_records (region, score) VALUES ('latest', 62.57);
