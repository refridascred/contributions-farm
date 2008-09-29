-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (owner, score, count, label) VALUES ('stable', 93.31, 8, 'eu-west');
INSERT INTO commits_records (owner, score, count, label) VALUES ('cached', 3.59, 82, 'stable');
