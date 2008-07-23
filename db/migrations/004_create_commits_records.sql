-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, score, ratio, label) VALUES ('standard', 21.92, 38.76, 'standard');
INSERT INTO commits_records (state, score, ratio, label) VALUES ('blue', 82.73, 36.82, 'legacy');
INSERT INTO commits_records (state, score, ratio, label) VALUES ('cached', 58.77, 19.41, 'primary');
