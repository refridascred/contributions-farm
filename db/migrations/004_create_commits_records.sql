-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, ratio, label, level) VALUES (34, 88.84, 96.72, 'stable', 97);
INSERT INTO commits_records (active, weight, ratio, label, level) VALUES (61, 59.84, 14.23, 'open', 38);
