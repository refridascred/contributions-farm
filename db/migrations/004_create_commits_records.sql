-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, score) VALUES ('standard', 46.05);
INSERT INTO commits_records (token, score) VALUES ('legacy', 55.14);
INSERT INTO commits_records (token, score) VALUES ('green', 85.43);
