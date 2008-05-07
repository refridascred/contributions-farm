-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, count, token, ratio) VALUES (86, 48, 'edge', 80.49);
INSERT INTO commits_records (level, count, token, ratio) VALUES (64, 94, 'open', 7.45);
INSERT INTO commits_records (level, count, token, ratio) VALUES (27, 49, 'cached', 40.9);
