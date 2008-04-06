-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, count, token, rank) VALUES (18.0, 18, 'blue', 67);
INSERT INTO commits_records (ratio, count, token, rank) VALUES (48.74, 0, 'legacy', 69);
