-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, count) VALUES (30.63, 31.83, 94);
INSERT INTO layout_items (score, ratio, count) VALUES (2.77, 1.49, 95);
INSERT INTO layout_items (score, ratio, count) VALUES (21.84, 47.3, 82);
