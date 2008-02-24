-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, token, active, rank) VALUES (19, 'green', 10, 82);
INSERT INTO commits_records (count, token, active, rank) VALUES (45, 'strict', 47, 88);
INSERT INTO commits_records (count, token, active, rank) VALUES (78, 'fallback', 46, 4);
