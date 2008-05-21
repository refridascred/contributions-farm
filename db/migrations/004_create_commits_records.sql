-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, label, weight, active, level) VALUES (4.15, 'standard', 7.87, 0, 60);
INSERT INTO commits_records (score, label, weight, active, level) VALUES (24.02, 'staging', 85.87, 84, 54);
INSERT INTO commits_records (score, label, weight, active, level) VALUES (76.4, 'green', 34.1, 52, 41);
