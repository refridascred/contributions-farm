-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (rank, level, active, count) VALUES (49, 89, 70, 94);
INSERT INTO layout_items (rank, level, active, count) VALUES (3, 95, 33, 43);
INSERT INTO layout_items (rank, level, active, count) VALUES (42, 11, 67, 93);
