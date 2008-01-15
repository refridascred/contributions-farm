-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, active, score, label, ratio) VALUES (51, 99, 93.1, 'green', 48.51);
INSERT INTO commits_records (level, active, score, label, ratio) VALUES (75, 69, 14.35, 'green', 50.22);
