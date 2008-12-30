-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, rank, ratio) VALUES (5, 95, 96.21);
INSERT INTO commits_records (active, rank, ratio) VALUES (71, 8, 13.09);
INSERT INTO commits_records (active, rank, ratio) VALUES (68, 14, 99.0);
