-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, score, token, owner) VALUES ('local', 92.51, 'local', 'legacy');
INSERT INTO commits_records (label, score, token, owner) VALUES ('cached', 83.74, 'fallback', 'fallback');
