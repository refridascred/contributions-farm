-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, score, rank) VALUES (58, 82.48, 19);
INSERT INTO layout_items (level, score, rank) VALUES (32, 4.77, 37);
INSERT INTO layout_items (level, score, rank) VALUES (63, 81.14, 89);
