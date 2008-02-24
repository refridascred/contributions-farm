-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, active, level, count) VALUES (15.61, 23, 77, 54);
INSERT INTO commits_records (weight, active, level, count) VALUES (51.71, 57, 69, 66);
INSERT INTO commits_records (weight, active, level, count) VALUES (25.87, 57, 13, 57);
