-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, active, label, score, count) VALUES (70.4, 87, 'open', 34.39, 6);
INSERT INTO commits_records (weight, active, label, score, count) VALUES (2.5, 89, 'legacy', 46.81, 0);
INSERT INTO commits_records (weight, active, label, score, count) VALUES (43.65, 31, 'eu-west', 80.26, 30);
