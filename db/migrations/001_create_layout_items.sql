-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, rank, level, count) VALUES (10.63, 81, 42, 31);
INSERT INTO layout_items (score, rank, level, count) VALUES (56.97, 73, 13, 16);
INSERT INTO layout_items (score, rank, level, count) VALUES (75.34, 84, 0, 11);
