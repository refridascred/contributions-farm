-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, weight, token, label) VALUES (80, 75.53, 'fallback', 'primary');
INSERT INTO commits_records (active, weight, token, label) VALUES (68, 60.4, 'primary', 'blue');
