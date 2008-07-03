-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, score, active, label) VALUES (3.08, 10.98, 21, 'staging');
INSERT INTO commits_records (weight, score, active, label) VALUES (1.16, 28.72, 17, 'open');
