-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, level, rank) VALUES (4.78, 7, 58);
INSERT INTO layout_items (ratio, level, rank) VALUES (52.91, 38, 67);
INSERT INTO layout_items (ratio, level, rank) VALUES (86.45, 56, 37);
