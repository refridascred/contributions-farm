-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, level, score) VALUES (78, 53, 39.48);
INSERT INTO layout_items (count, level, score) VALUES (13, 80, 72.12);
INSERT INTO layout_items (count, level, score) VALUES (89, 71, 75.57);
