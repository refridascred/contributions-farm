-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, active, region, state) VALUES (5.3, 'primary', 43, 'edge', 'fallback');
INSERT INTO commits_records (weight, label, active, region, state) VALUES (35.44, 'primary', 31, 'open', 'legacy');
INSERT INTO commits_records (weight, label, active, region, state) VALUES (35.75, 'green', 76, 'local', 'primary');
