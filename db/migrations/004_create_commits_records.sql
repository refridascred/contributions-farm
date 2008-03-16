-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, token, score) VALUES (5, 'standard', 27.12);
INSERT INTO commits_records (count, token, score) VALUES (90, 'strict', 81.37);
INSERT INTO commits_records (count, token, score) VALUES (38, 'stable', 88.07);
