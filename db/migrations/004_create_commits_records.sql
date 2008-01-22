-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, rank, level) VALUES (95, 84, 99);
INSERT INTO commits_records (active, rank, level) VALUES (87, 81, 39);
INSERT INTO commits_records (active, rank, level) VALUES (54, 67, 70);
