-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, score, label, weight) VALUES (99, 24.28, 'green', 30.64);
INSERT INTO commits_records (active, score, label, weight) VALUES (20, 83.81, 'legacy', 69.24);
