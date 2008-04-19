-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, rank, score, owner) VALUES (0.5, 52, 65.88, 'cached');
INSERT INTO layout_items (ratio, rank, score, owner) VALUES (37.4, 45, 74.93, 'standard');
INSERT INTO layout_items (ratio, rank, score, owner) VALUES (98.8, 83, 33.13, 'fallback');
