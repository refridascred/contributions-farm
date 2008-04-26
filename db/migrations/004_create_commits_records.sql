-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, state, score, owner, weight) VALUES ('cached', 'edge', 23.91, 'stable', 66.16);
INSERT INTO commits_records (label, state, score, owner, weight) VALUES ('fallback', 'green', 94.51, 'edge', 77.07);
