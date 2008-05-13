-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, label, weight, level, active) VALUES (92, 'standard', 92.49, 79, 87);
INSERT INTO commits_records (count, label, weight, level, active) VALUES (30, 'strict', 46.87, 18, 26);
