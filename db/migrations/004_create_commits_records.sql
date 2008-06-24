-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, active, rank, level) VALUES (43.66, 43, 97, 71);
INSERT INTO commits_records (weight, active, rank, level) VALUES (11.07, 26, 44, 15);
INSERT INTO commits_records (weight, active, rank, level) VALUES (76.23, 66, 88, 44);
