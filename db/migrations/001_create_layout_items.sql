-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, score, rank, level) VALUES (2.57, 43.16, 39, 94);
INSERT INTO layout_items (ratio, score, rank, level) VALUES (58.8, 52.75, 94, 92);
