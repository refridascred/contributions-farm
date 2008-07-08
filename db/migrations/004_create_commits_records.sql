-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, score) VALUES ('latest', 23.73);
INSERT INTO commits_records (token, score) VALUES ('local', 93.96);
INSERT INTO commits_records (token, score) VALUES ('blue', 12.26);
