-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, label, score, level, active) VALUES (59.71, 'fallback', 24.5, 30, 79);
INSERT INTO commits_records (weight, label, score, level, active) VALUES (39.26, 'eu-west', 67.99, 67, 4);
