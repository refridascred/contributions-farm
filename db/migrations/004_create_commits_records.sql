-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, score, label, rank) VALUES ('fallback', 78.84, 'strict', 80);
INSERT INTO commits_records (state, score, label, rank) VALUES ('standard', 94.16, 'fallback', 39);
INSERT INTO commits_records (state, score, label, rank) VALUES ('strict', 50.68, 'legacy', 96);
