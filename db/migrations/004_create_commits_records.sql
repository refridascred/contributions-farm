-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, ratio, active, rank) VALUES ('blue', 56.5, 30, 57);
INSERT INTO commits_records (region, ratio, active, rank) VALUES ('primary', 18.78, 29, 38);
INSERT INTO commits_records (region, ratio, active, rank) VALUES ('green', 10.55, 8, 77);
