-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, level, count) VALUES (50, 15, 78);
INSERT INTO layout_items (rank, level, count) VALUES (13, 2, 6);
INSERT INTO layout_items (rank, level, count) VALUES (72, 0, 89);
