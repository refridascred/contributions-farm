-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, active, owner, token, score) VALUES ('local', 76, 'legacy', 'strict', 31.14);
INSERT INTO commits_records (label, active, owner, token, score) VALUES ('latest', 26, 'primary', 'primary', 51.34);
