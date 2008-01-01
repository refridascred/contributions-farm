-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, score, active) VALUES ('eu-west', 66.66, 2);
INSERT INTO commits_records (region, score, active) VALUES ('cached', 77.98, 31);
INSERT INTO commits_records (region, score, active) VALUES ('blue', 51.91, 47);
