-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, ratio, label, owner, level) VALUES (83, 14.33, 'fallback', 'open', 36);
INSERT INTO commits_records (rank, ratio, label, owner, level) VALUES (46, 93.95, 'cached', 'primary', 20);
