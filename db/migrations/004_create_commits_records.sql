-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, rank, level, weight) VALUES (85, 3, 67, 75.55);
INSERT INTO commits_records (active, rank, level, weight) VALUES (33, 24, 17, 43.49);
INSERT INTO commits_records (active, rank, level, weight) VALUES (51, 28, 62, 66.19);
