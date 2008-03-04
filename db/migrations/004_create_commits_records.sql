-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, active, state, ratio, label) VALUES (25.53, 50, 'strict', 81.59, 'primary');
INSERT INTO commits_records (weight, active, state, ratio, label) VALUES (16.74, 18, 'eu-west', 65.92, 'standard');
INSERT INTO commits_records (weight, active, state, ratio, label) VALUES (10.83, 15, 'blue', 41.87, 'fallback');
