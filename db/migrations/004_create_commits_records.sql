-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, level, rank, ratio) VALUES (11.34, 85, 38, 82.8);
INSERT INTO commits_records (weight, level, rank, ratio) VALUES (69.98, 72, 4, 16.79);
