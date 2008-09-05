-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, state, label, count) VALUES (28.66, 'eu-west', 'fallback', 61);
INSERT INTO commits_records (weight, state, label, count) VALUES (91.39, 'cached', 'legacy', 13);
INSERT INTO commits_records (weight, state, label, count) VALUES (38.57, 'eu-west', 'strict', 44);
