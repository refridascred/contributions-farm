-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, label, level, rank) VALUES (7.84, 'strict', 62, 1);
INSERT INTO commits_records (weight, label, level, rank) VALUES (8.07, 'standard', 14, 92);
