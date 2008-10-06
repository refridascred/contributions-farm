-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, region, score, count) VALUES (43, 'standard', 0.88, 28);
INSERT INTO layout_items (rank, region, score, count) VALUES (82, 'latest', 68.3, 92);
INSERT INTO layout_items (rank, region, score, count) VALUES (87, 'staging', 36.04, 7);
