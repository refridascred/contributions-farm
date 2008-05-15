-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, level, score) VALUES (7, 36, 12.73);
INSERT INTO layout_items (rank, level, score) VALUES (7, 77, 40.47);
INSERT INTO layout_items (rank, level, score) VALUES (37, 14, 44.94);
