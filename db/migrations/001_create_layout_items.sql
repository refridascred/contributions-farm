-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, count, score, ratio) VALUES (71, 77, 89.28, 72.17);
INSERT INTO layout_items (level, count, score, ratio) VALUES (41, 29, 22.39, 55.87);
INSERT INTO layout_items (level, count, score, ratio) VALUES (10, 15, 69.08, 2.89);
