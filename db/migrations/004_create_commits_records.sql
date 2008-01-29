-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, score, count, label) VALUES ('legacy', 94.88, 70, 'stable');
INSERT INTO commits_records (token, score, count, label) VALUES ('local', 68.75, 95, 'blue');
