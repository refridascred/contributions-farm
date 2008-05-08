-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, label, active) VALUES (40.5, 'fallback', 5);
INSERT INTO commits_records (weight, label, active) VALUES (69.87, 'standard', 34);
INSERT INTO commits_records (weight, label, active) VALUES (50.05, 'standard', 43);
