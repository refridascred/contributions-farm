-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, token, owner, score) VALUES (17, 'strict', 'cached', 11.27);
INSERT INTO commits_records (count, token, owner, score) VALUES (75, 'green', 'edge', 94.73);
INSERT INTO commits_records (count, token, owner, score) VALUES (95, 'fallback', 'green', 59.46);
