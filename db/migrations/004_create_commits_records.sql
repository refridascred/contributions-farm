-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, ratio) VALUES (70, 38.12, 75.59);
INSERT INTO commits_records (active, weight, ratio) VALUES (67, 23.34, 26.33);
INSERT INTO commits_records (active, weight, ratio) VALUES (53, 51.2, 38.43);
