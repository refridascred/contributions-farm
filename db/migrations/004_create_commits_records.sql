-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, count) VALUES ('blue', 13);
INSERT INTO commits_records (token, count) VALUES ('latest', 20);
INSERT INTO commits_records (token, count) VALUES ('staging', 37);
