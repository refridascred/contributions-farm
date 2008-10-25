-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, score, active, rank, label) VALUES (61, 22.6, 88, 76, 'fallback');
INSERT INTO commits_records (level, score, active, rank, label) VALUES (64, 4.7, 88, 48, 'standard');
INSERT INTO commits_records (level, score, active, rank, label) VALUES (75, 17.64, 30, 4, 'edge');
