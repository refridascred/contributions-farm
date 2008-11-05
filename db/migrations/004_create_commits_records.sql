-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, score) VALUES ('staging', 43.42);
INSERT INTO commits_records (region, score) VALUES ('fallback', 35.42);
INSERT INTO commits_records (region, score) VALUES ('eu-west', 94.54);
