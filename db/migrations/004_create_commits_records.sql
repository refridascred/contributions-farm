-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, weight, active, label) VALUES ('stable', 35.8, 0, 'fallback');
INSERT INTO commits_records (state, weight, active, label) VALUES ('open', 96.07, 71, 'strict');
INSERT INTO commits_records (state, weight, active, label) VALUES ('strict', 39.78, 68, 'open');
